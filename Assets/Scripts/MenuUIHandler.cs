using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField NameInput;
    public void NewNameSelected(string name)
    {
        MainManager.Instance.PlayerName = name;
    }

    
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        NewNameSelected(NameInput.GetComponent<Text>().text);
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
        //save game
    }
}
