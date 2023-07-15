using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public static MainMenu Instance;

    public InputField inputField;
    public string userName;

    public string nameBest;

    public int scoreBest;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
        SaveNameInput();
    }
    public void SaveNameInput()
    {
        if (userName != inputField.text)
        {
            userName = inputField.text;
        }
    }

}
