using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public AudioSource flapSFX;
    public LogicScript logic;
    public bool birdIsAlive = true;


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {

            myRigidbody.linearVelocity = Vector2.up * flapStrength;
            PlayFlapSound();
        }

        if (transform.position.y >= 15 || transform.position.y <= -15)
        {
            gameOver();
        }
    }
    private void gameOver()
    {
        logic.gameOver();
        birdIsAlive = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
    public void PlayFlapSound()
    {
        flapSFX.Play();
    }
}