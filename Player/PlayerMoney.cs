using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerMoney : MonoBehaviour
{
    public int playerMoney;
    public TMP_Text coinsText;

    void Start()
    {
        playerMoney = PlayerPrefs.GetInt("coin");
        coinsText.text = playerMoney.ToString();
    }

    public bool TryRemoveMoney(int moneyToRemove)
    {
        if (playerMoney >= moneyToRemove)
        {
            playerMoney -= moneyToRemove;
            PlayerPrefs.SetInt("coin", playerMoney);
            return true;
        }
        else
        {
            return false;
        }
    }

}
