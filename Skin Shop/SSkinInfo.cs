using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName ="New Skin", menuName = "Create New Skin")]
public class SSkinInfo : ScriptableObject
{

    public enum SkinIDs { brown, red, green, purple, blue, pink, white, orange }
    public SkinIDs skinID;

    public Sprite skinSprite;

    public int skinPrice;

}
