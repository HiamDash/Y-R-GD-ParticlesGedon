using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int _score, HightScore;
    public TMP_Text ScoreText;

    public GameObject ZomdiDoctor;
    public GameObject ZombiSoliders;

    public AudioSource PlayerAudioSource;
    public AudioClip ZombiSoud;

    void Awake()
    {
        if(PlayerPrefs.HasKey("SaveScore"))
        {
        HightScore = PlayerPrefs.GetInt("SaveScore", 0);
        }
    }

    void Update()
    {
        ScoreText.text = ("Infected " + (int)_score).ToString();
    }
     
     private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            
            AddScore();
            Destroy(other.gameObject);
            GameObject ZomdiDoctorRef = (GameObject)Instantiate(ZomdiDoctor);
            ZomdiDoctorRef.transform.position = new Vector3(transform.position.x-1, transform.position.y+4, transform.position.z);
            PlayerAudioSource.PlayOneShot(ZombiSoud);
        }
      
        if (other.CompareTag("EnemySolider"))
        {
            AddScore();
            Destroy(other.gameObject);
            GameObject ZombiSolidersRef = (GameObject)Instantiate(ZombiSoliders);
            ZombiSolidersRef.transform.position = new Vector3(transform.position.x-1, transform.position.y+4, transform.position.z);
            PlayerAudioSource.PlayOneShot(ZombiSoud);
        }
    }
   
    public void AddScore()
    {
        _score ++;
        AddHightScore();
    }

    public void AddHightScore()
    {
        if(_score> HightScore)
        {
            HightScore= _score;
            PlayerPrefs.SetInt("SaveScore", HightScore);        
        }
    }
    public void ResetScore()
    {
        _score = 0;
    }
}
