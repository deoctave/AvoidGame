using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CarMovement : MonoBehaviour
{
    public float MaxSpeed;
    public float acc;
    public float steering;
    public Joystick joystick;
    public static int playerMoney;
    public GameObject parttama;
    public GameObject menuProigrish;
    public GameObject joystickk;
    Rigidbody2D rb;
    public GameObject coinSound;
    
    float X;
    float Y = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerMoney = PlayerPrefs.GetInt("coin");
    }


    private void Update()
    {
        X = joystick.Horizontal;
        Vector2 speed = transform.up * (Y * acc);
        rb.AddForce(speed);

        float direction = Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.up));

        if (acc > 0)
        {
            if (direction > 0)
            {
                rb.rotation -= X * steering * (rb.velocity.magnitude / MaxSpeed);
            }
            else
            {
                rb.rotation += X * steering * (rb.velocity.magnitude / MaxSpeed);
            }
        }

        float driftForce = Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.left)) * 2.0f;

        Vector2 relativeForce = Vector2.right * driftForce;

        rb.AddForce(rb.GetRelativeVector(relativeForce));

        if(rb.velocity.magnitude > MaxSpeed)
        {
            rb.velocity = rb.velocity.normalized * MaxSpeed;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "stena" || other.tag == "stenischez" || other.tag == "aienemy")
        {
            gameObject.SetActive(false);
            joyystickk.SetActive(false);
            Destroy(Instantiate(parttama, transform.position, Quaternion.identity), 0.4f);
            menuProigrish.SetActive(true);
        }


        if (other.tag == "coin")
        {
            playerMoney += 5;
            PlayerPrefs.SetInt("coin", playerMoney);
            Destroy(other.gameObject);
            Instantiate(coinSound, transform.position, Quaternion.identity);
        }
    }
}


