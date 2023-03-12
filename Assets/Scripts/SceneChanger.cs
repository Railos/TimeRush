using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public Image fader;
    public float step;

    private void OnEnable()
    {
        StartCoroutine("StartPlayAnimation");
        
    }

    public void Change(string scene)
    {
        StartCoroutine("PlayAnimation", scene);
    }

    IEnumerator PlayAnimation(string scene)
    {
        while (fader.color.a < 1f)
        {

            Color color = fader.color;
            color.a += step;
            fader.color = color;
            yield return new WaitForSeconds(0.1f);
        }
        PlayerPrefs.SetString("lastLevel", scene);
        SceneManager.LoadScene(scene);
    }
    
    IEnumerator StartPlayAnimation()
    {
        fader.color = new Color(0f, 0f, 0f, 1f);
        while (fader.color.a > 0f)
        {

            Color color = fader.color;
            color.a -= step;
            fader.color = color;
            yield return new WaitForSeconds(0.1f);
        }

    }
}