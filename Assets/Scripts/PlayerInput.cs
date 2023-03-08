using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private WorldSwitcher worldSwitcher;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            worldSwitcher.SwitchWorlds();
        }
    }
}
