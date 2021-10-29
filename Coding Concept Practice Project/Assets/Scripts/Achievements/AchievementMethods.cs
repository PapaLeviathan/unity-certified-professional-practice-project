using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementMethods : MonoBehaviour
{
    public void PressedAchievementButton()
    {
        AchievementManager.AchievementStep(Achievement.StepType.ButtonPressed);
    }

    public void MultiPressedAchievementButtun()
    {
        AchievementManager.AchievementStep(Achievement.StepType.Button2Pressed, 1);
    }
}
