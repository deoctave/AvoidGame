using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public GameObject pauseGameMenu;
    public AudioSource myFX;
    public AudioClip clickFx;
    public InterstitialAd ad;
    public RewardedAds rAd;
    private void Start()
    {
        rAd.LoadAd();
    }
    public void Resume()
    {
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        ad.ShowLevelAd();
        SceneManager.LoadScene("RaceRejMenu");
    }
    public void LoadGlMenu()
    {
        Time.timeScale = 1f;
        ad.ShowAd();
        SceneManager.LoadScene("VibrScene");
    }

    public void ClickSound()
    {
        myFX.PlayOneShot(clickFx);
    }
}
