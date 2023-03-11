using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("Main")]
    [SerializeField] private GameObject settingsCanvas;
    [SerializeField] private GameObject mainCanvas;
    [SerializeField] private GameObject backButton;
    public TMP_InputField sens;
    [Header("Settings")] 
    [SerializeField] private int ww;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    

    public void StartGame()
    {
        SceneManager.LoadScene("1");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Settings()
    {
        settingsCanvas.SetActive(true);
        mainCanvas.SetActive(false);
        backButton.SetActive(true);
    }

    public void Back()
    {
        backButton.SetActive(false);
        settingsCanvas.SetActive(false);
        mainCanvas.SetActive(true);
    }

    public void SensChanged()
    {
        int newSens = int.Parse(sens.text);
        PlayerPrefs.SetInt("sens", newSens);
    }

    public void UpdateSens()
    {
        sens.text = PlayerPrefs.GetInt("sens", 500).ToString();
    }
}
