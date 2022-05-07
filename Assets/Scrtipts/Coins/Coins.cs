using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Coins : MonoBehaviour
{
    public int coins;
    public TMP_Text coinsText;
    public AudioSource PlayerAudioSource;
    public AudioClip CoinsSoundAudioClip;
    
    void Start()
    {
        if (PlayerPrefs.HasKey("coins"))
        {
            coins= PlayerPrefs.GetInt("coins");
        }
    }
    void Update()
    {
        coinsText.text = ("Coins " + (int)coins).ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("coin"))
        {
        coins++;
        PlayerAudioSource.PlayOneShot(CoinsSoundAudioClip);
        Destroy(other.gameObject);
        PlayerPrefs.SetInt("coins",coins);
        }
    }
}