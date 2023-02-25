using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextLevel : MonoBehaviour
{
    public GameObject winMenu;
    public GameObject jostick;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("mashina"))
        {
            UnLockLevel();
              jostick.SetActive(false);
              winMenu.SetActive(true);
              Time.timeScale = 0f;
        }
    }


    public void UnLockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("levels"))
        {
            PlayerPrefs.SetInt("levels", currentLevel + 1);
        }
    }
}
