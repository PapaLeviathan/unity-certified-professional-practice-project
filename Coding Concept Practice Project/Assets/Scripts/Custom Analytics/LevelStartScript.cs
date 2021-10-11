using UnityEngine;

public class LevelStartScript : MonoBehaviour
{
    private void Start()
    {
        CustomAnalytics.SendLevelStart(GameProgress.CurrentLevel);
    }
}