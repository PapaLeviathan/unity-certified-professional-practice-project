using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManagerButton : MonoBehaviour
{
    public void SaveGame()
    {
        SaveGameManager.Save();
    }
    public void LoadSave()
    {
        SaveGameManager.Load();
        
    }
    public void DeleteSave()
    {
        SaveGameManager.DeleteSave();
    }
}
