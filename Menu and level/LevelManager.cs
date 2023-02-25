using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    int levelUnLock;
    public Button[] buttons;
    public AudioSource myFX;
    public AudioClip clickFx;
    public static int kolvoReklamiLevel;


    void Start()
    {
        levelUnLock = PlayerPrefs.GetInt("levels", 1);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        for (int i = 0; i <= levelUnLock; i++)
        {
            buttons[i].interactable = true;
        }
    }

    public void loadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
        kolvoReklamiLevel += 1;
        PlayerPrefs.SetInt("schet4reklev", kolvoReklamiLevel);
    }

    public void LoadGlavMenu()
    {
        SceneManager.LoadScene("VibrScene");
    }

    public void ClickSound()
    {
        myFX.PlayOneShot(clickFx);
    }
}


