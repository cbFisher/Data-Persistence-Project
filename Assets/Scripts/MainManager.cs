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

    public string PlayerName;

    



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
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    [System.Serializable]

    class SaveData
    {
        public string PlayerName;
    }


  //  public void SaveName()
  //  {
  //      SaveData data = new SaveData();
  //
  //      data.PlayerName = PlayerName;
  //
  //      string json = JsonUtility.ToJson(data);
  //      File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
  //
   // }
}
