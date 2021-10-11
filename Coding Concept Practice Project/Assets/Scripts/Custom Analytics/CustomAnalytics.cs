using System.Collections;
using System.Collections.Generic;
using UnityEngine.Analytics;
using System;
using UnityEngine;

static public class CustomAnalytics
{
    static public void SendLevelStart(int level)
    {
        AnalyticsResult dateAndTime = Analytics.CustomEvent("LevelStart", new Dictionary<string, object> {{"Time", DateTime.Now}});
        AnalyticsResult currentlevel = Analytics.CustomEvent("LevelStart", new Dictionary<string, object> {{"Level", level}});
        Debug.Log("Date and time: " + dateAndTime);
        Debug.Log("CurrentLevel: " + currentlevel);
    }
}