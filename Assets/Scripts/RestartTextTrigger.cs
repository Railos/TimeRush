using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RestartTextTrigger : MonoBehaviour
{
    [SerializeField] private GameObject text;
    [SerializeField] private GameObject typingText;

    private void Start()
    {
        text.SetActive(false);
        typingText.SetActive(true);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Restartatble"))
        {
            text.SetActive(true);
            typingText.SetActive(false);
        }
            
    }
}
