using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("Main")]
    [SerializeField] private GameObject settingsCanvas;
    [SerializeField] private GameObject mainCanvas;
    [SerializeField] private GameObject backButton;

    [Header("Settings")] 
    [SerializeField] private int ww;
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
}
