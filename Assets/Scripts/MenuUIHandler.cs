using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField NameInput;
    private string m_Text;

    //public GameObject inputName;
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
        m_Text = NameInput.text;

        Debug.Log(m_Text);
        NewNameSelected(m_Text);
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
