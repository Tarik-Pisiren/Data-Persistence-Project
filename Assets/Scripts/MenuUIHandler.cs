using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;


public class MenuUIHandler : MonoBehaviour
{
    public static string playerName;
    public TMP_InputField enterName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }


    public void QuitGame()
    {
#if (UNITY_EDITOR)
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void SavePlayerName()
    {
        playerName = enterName.text;
        Debug.Log(playerName);
    }
}
