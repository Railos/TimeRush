using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private WorldSwitcher worldSwitcher;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            worldSwitcher.SwitchWorlds();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
