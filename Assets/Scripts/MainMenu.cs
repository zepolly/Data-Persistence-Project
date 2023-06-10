using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenu : MonoBehaviour
{
    public static MainMenu Instance;
    public InputField inputField;
    public string userName; 

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);

    }

    private void Update()
    {
        if (userName != inputField.text)
        {
            userName = inputField.text;
        }
    }

}
