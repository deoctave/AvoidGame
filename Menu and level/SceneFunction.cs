using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFunction : MonoBehaviour
{
    public AudioSource myFX;
    public AudioClip clickFx;
    public AudioClip clickCarFx;
    public static int kolvoReklami;

    public void ViborRejMenu()
    {
        SceneManager.LoadScene("RaceRejMenu");
    }
    public void LoadSurvivRej()
    {
        SceneManager.LoadScene("SurvLvl1");
    }
    public void ClickSound()
    {
        myFX.PlayOneShot(clickFx);
        kolvoReklami += 1;
        PlayerPrefs.SetInt("schet4rek", kolvoReklami);
    }
    public void ClickCarSound()
    {
        myFX.PlayOneShot(clickCarFx);
    }
}
