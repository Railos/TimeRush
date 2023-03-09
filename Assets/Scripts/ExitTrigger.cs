using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTrigger : MonoBehaviour
{
    public string sceneName;
    
    private void OnTriggerEnter(Collider other)
    {
        SceneChanger changer;
        other.gameObject.TryGetComponent<SceneChanger>(out changer);
        if (changer != null)
        {
            changer.Change(sceneName);
        }
    }
}
