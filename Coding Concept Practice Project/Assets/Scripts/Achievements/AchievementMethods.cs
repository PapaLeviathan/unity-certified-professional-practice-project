using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementMethods : MonoBehaviour
{
    public void PressedAchievementButton()
    {
        AchievementManager.AchievementStep(Achievement.StepType.ButtonPressed);
    }
}
