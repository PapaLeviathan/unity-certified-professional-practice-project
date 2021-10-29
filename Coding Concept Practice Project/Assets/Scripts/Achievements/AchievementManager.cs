using System;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    static private AchievementManager _achievementManager;

    public AchievementPopUp _popUp;
    public StepRecord[] _stepRecords;
    public Achievement[] _achievements;

    static private Dictionary<Achievement.StepType, StepRecord> _stepRecordDictionary;

    private void Awake()
    {
        Achievement_Manager = this;
        
        _stepRecordDictionary = new Dictionary<Achievement.StepType, StepRecord>();

        foreach (StepRecord stepRecord in _stepRecords)
        {
            _stepRecordDictionary.Add(stepRecord.Type, stepRecord);
        }
    }

    static private AchievementManager Achievement_Manager
    {
        get
        {
            if (_achievementManager == null)
            {
                Debug.LogError(
                    "AchievementManager: Achievement_Manager getter - Attempt to get value of Achievement_Manager before it has been set.");
                return null;
            }

            return _achievementManager;
        }
        set
        {
            if (_achievementManager != null)
            {
                Debug.LogError(
                    "AchievementManager: Achievement_Manager setter - Attempt to set Achievement_Manager when it has already been set.");
            }

            _achievementManager = value;
        }
    }

    static public void AchievementStep(Achievement.StepType stepType, int num = 1)
    {
        StepRecord stepRecord = _stepRecordDictionary[stepType];

        if (stepRecord != null)
        {
            stepRecord.Progress(num);

            foreach (Achievement achievement in Achievement_Manager._achievements)
            {
                if (!achievement.complete)
                {
                    if (achievement.CheckCompletion(stepType, stepRecord.num))
                    {
                        AnnounceAchievementCompletion(achievement);
                    }
                }
            }
        }
    }

    private static void AnnounceAchievementCompletion(Achievement achievement)
    {
        Achievement_Manager.TriggerPopUp(achievement.Title, achievement.Description);
    }

    private void TriggerPopUp(string achievementTitle, string achievementDescription)
    {
        _popUp.PopUp(achievementTitle, achievementDescription);
    }
}

[System.Serializable]
public class StepRecord
{
    public Achievement.StepType Type;

    public bool cumulative;

    private int _num;

    public int num
    {
        get => _num;
        private set => _num = value;
    }

    public void Progress(int num)
    {
        if (cumulative)
            _num += num;
        else
            _num = num;
    }
}

[System.Serializable]
public class Achievement
{
    [SerializeField] private bool _complete = false;

    public string Title = "Default Title";
    public string Description = "Default Description";
    public StepType _stepType;
    public int _stepCount;

    public bool complete
    {
        get => _complete;
        private set => _complete = value;
    }

    public enum StepType
    {
        ButtonPressed,
        Button2Pressed,
        Button3Pressed
    }

    public bool CheckCompletion(StepType type, int num)
    {
        if (type != _stepType || complete)
        {
            return false;
        }

        if (num >= _stepCount)
        {
            complete = true;
            return true;
        }

        return false;
    }
}