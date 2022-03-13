using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpeedSistem : MonoBehaviour
{
    public float moveSpeed;
    public AudioSource PlayerAudioSource;
    public AudioClip speedBoostAudioClip;
    public AudioClip crashSoundAudioClip;

    public static bool GameIsLost;
    public GameObject deathMenuUI;



    Rigidbody2D rb;
    Collider2D myCollider;
    private UnityEngine.Object explosion;    
    private UnityEngine.Object speed;   
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
        explosion = Resources.Load("Explosion");
    }

     void Update()
    {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        moveSpeed +=0.1F * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("speedBoost"))
        {
            PlayerAudioSource.PlayOneShot(speedBoostAudioClip);
            moveSpeed += 5;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("speedLet"))
        {
            PlayerAudioSource.PlayOneShot(crashSoundAudioClip);
            GameObject explosionRef = (GameObject)Instantiate(explosion);
            explosionRef.transform.position = new Vector3(transform.position.x+5, transform.position.y+5, transform.position.z);
            Destroy(other.gameObject);
            Menu();
        }
        if (other.CompareTag("speedCheck"))
        {
            // if(moveSpeed >= 35)
            // {
            Destroy(other.gameObject);
            GameObject explosionRef = (GameObject)Instantiate(explosion);
            explosionRef.transform.position = new Vector3(transform.position.x+5, transform.position.y+5, transform.position.z);
            PlayerAudioSource.PlayOneShot(crashSoundAudioClip);
            // }
            // else
            // {
            // PlayerAudioSource.PlayOneShot(crashSoundAudioClip);
            // SceneManager.LoadScene(0);
            // }
        }
    }
    public void SecondChance()
    {
        Play();
    }
     public void Menu()
    {
        deathMenuUI.SetActive(true);
        Time.timeScale= 0f;
        GameIsLost = true;
    }

     public void Play()
    {
    deathMenuUI.SetActive(false);
    Time.timeScale= 1f;
    GameIsLost = false;
    }
}
