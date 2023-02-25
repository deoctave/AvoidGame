using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinLoader : MonoBehaviour
{
    public SpriteRenderer playerSR;

    public void Awake()
    {
        playerSR.sprite = SkinManager.equippedSkin;
    }
}
