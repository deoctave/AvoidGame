using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject cplayer;
    public float rasstoyaniteSozdy;
    public float rasstoyaniteSozdx;
    public float sekundi;
    void Start()
    {
        StartCoroutine(Spawn());
    }


    IEnumerator Spawn()
    {
        while (true)
        {
            Instantiate(enemy, new Vector2(cplayer.transform.position.x + rasstoyaniteSozdx, cplayer.transform.position.y + rasstoyaniteSozdy), Quaternion.identity);
            yield return new WaitForSeconds(sekundi);
        }
    }

}
