using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class SaveInfo
{
   public int _highScore = 5000;
   public Toggle _selectedToggle = ToggleGroupTester.CurrentSelection;
}
