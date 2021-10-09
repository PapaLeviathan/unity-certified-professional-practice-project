using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ToggleGroupTester : MonoBehaviour
{
   private static ToggleGroup _toggleGroupInstance;

   public static Toggle CurrentSelection { get { return _toggleGroupInstance.ActiveToggles().FirstOrDefault(); } }
   private void Start()
   {
      _toggleGroupInstance = GetComponent<ToggleGroup>();
      Debug.Log("First Selected is " + CurrentSelection.name);
   }

   public void SelectToggle(int id)
   {
      var toggles = _toggleGroupInstance.GetComponentsInChildren<Toggle>();
      toggles[id].isOn = true;
   }

   public static void LoadTogglesFromSaveFile(SaveInfo saveInfo)
   {
      saveInfo._selectedToggle.isOn = true;
   }
}
