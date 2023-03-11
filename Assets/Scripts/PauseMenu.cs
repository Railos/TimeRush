using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public PlayerInput PlayerInput;
    public PlayerCam PlayerCam;
    public TMP_InputField sens;

    

    public void StartGame()
    {
        SceneManager.LoadScene("1");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    

    public void SensChanged()
    {
        int newSens = int.Parse(sens.text);
        PlayerPrefs.SetInt("sens", newSens);
        PlayerCam.UpdateSens();
    }

    public void UpdateSens()
    {
        sens.text = PlayerPrefs.GetInt("sens", 500).ToString();
    }

    public void Resume()
    {
        PlayerInput.Pause();
    }
}
