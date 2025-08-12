using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Overlays;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance { get; private set; }

    public string bestPlayerName;
    public string currentPlayerName;

    public int highScore = 0;

    



    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        LoadBest();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    [System.Serializable]

    class SaveData
    {
        public string bestPlayerName;

        public int highScore;
    }


   public void SaveBest()
    {
        SaveData data = new SaveData();
  
       data.bestPlayerName = bestPlayerName;
        data.highScore = highScore;
  
       string json = JsonUtility.ToJson(data);
       File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadBest()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestPlayerName = data.bestPlayerName;
            highScore = data.highScore;
        }
    }
}
