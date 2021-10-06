using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveGameManager
{
    private static SaveInfo _saveInfo;
    private static string _filePath;

    static public bool LOCK { get; private set; }

    static SaveGameManager()
    {
        LOCK = false;
        _filePath = Application.persistentDataPath + "/CodingConceptPracticeProject.save";
        _saveInfo = new SaveInfo();
    }

    public static void Save()
    {
        if (LOCK) return;

        _saveInfo._highScore = 1000;

        string jsonSaveFile = JsonUtility.ToJson(_saveInfo, true);
        File.WriteAllText(_filePath, jsonSaveFile);

        Debug.Log("SaveGameManager: Save() - Path: " + _filePath);
        Debug.Log("SaveGameManager: Save() - JSON: " + jsonSaveFile);
    }

    public static void Load()
    {
        if (File.Exists(_filePath))
        {
            string dataAsJson = File.ReadAllText(_filePath);

            try
            {
                _saveInfo = JsonUtility.FromJson<SaveInfo>(dataAsJson);
            }
            catch
            {
                Debug.LogWarning("SaveGameManager:Load() – SaveFile was malformed.\n" + dataAsJson);
                return;
            }

            //Lock is set to true to protect save file while loading code
            LOCK = true;
            //here is where you would assign data from _saveInfo to the fields of, for example, an Achievement Manager,
            //A Game Manager, a UI Manager, character cosmetics, etc
            //This is what "Loading" is, assigning variables from a save file to the fields
            //of the current game state
            LOCK = false; //makes it so you can save again
        }
    }
    
    static public void DeleteSave()
    {
        if (File.Exists(_filePath))
        {
            File.Delete(_filePath);
            _saveInfo = new SaveInfo();
            Debug.Log("SaveGameManager:DeleteSave() – Successfully deleted save file.");
        }
        else
        {
            Debug.LogWarning("SaveGameManager:DeleteSave() – Unable to find and delete save file!"
                             + " This is absolutely fine if you've never saved or have just deleted the file.");
        }

        // Lock the file to prevent any saving
        LOCK = true;

       //Here is where you would RESET all values and states in various scripts

        // Unlock the file
        LOCK = false;
    }
}