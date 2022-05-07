using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpeedBonusDeathSistem : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    public AudioSource PlayerAudioSource;
    public AudioClip SpeedBoostAudioClip;
    public AudioClip CrashSoundAudioClip;
    public GameObject DeathMenuUI;
    public GameObject ResumeUI;
    public GameObject ShieldOnPlayer;
    [SerializeField] private GameObject SecondChanceButtonUI;

    private bool SecondChanceCheck;
    private Rigidbody2D _playerRigidBody;
    private Collider2D _myCollider;
    private UnityEngine.Object _explosion;    
    private bool _shieldActivity;

    void Start()
    {
        SecondChanceCheck = true;
        _shieldActivity = false;
        ShieldOnPlayer.SetActive(false);
        _playerRigidBody = GetComponent<Rigidbody2D>();
        _myCollider = GetComponent<Collider2D>();
        _explosion = Resources.Load("Explosion");
    }

     void Update()
    {
        _playerRigidBody.velocity = new Vector2(_moveSpeed, _playerRigidBody.velocity.y);
        _moveSpeed +=0.5F * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("speedBoost"))
        {
            PlayerAudioSource.PlayOneShot(SpeedBoostAudioClip);
            StartCoroutine(SpeedBurst());
            Destroy(other.gameObject);
        }
        if (other.CompareTag("shield"))
        {
            StartCoroutine(ShieldActivation());
            PlayerAudioSource.PlayOneShot(SpeedBoostAudioClip);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("speedLet"))
        {
            
            if(_shieldActivity)
            {
            PlayerAudioSource.PlayOneShot(CrashSoundAudioClip);
            ExplosionActivation();
            Destroy(other.gameObject); 
            }
            else
            {
            PlayerAudioSource.PlayOneShot(CrashSoundAudioClip);
            ExplosionActivation();
            Destroy(other.gameObject);
            Menu();
            }
        }
        if (other.CompareTag("speedCheck"))
        {
            Destroy(other.gameObject);
            ExplosionActivation();
            PlayerAudioSource.PlayOneShot(CrashSoundAudioClip);
        }
 
    }
    public void SecondChance()
    {
        if(SecondChanceCheck==true)
        {
        ResumeUI.SetActive(true);
        Play();
        SecondChanceCheck = false;
        SecondChanceButtonUI.SetActive(false);
        }
    }
     public void Menu()
    {
        ResumeUI.SetActive(false);
        DeathMenuUI.SetActive(true);
        Time.timeScale= 0f;
    }

     public void Play()
    {
        DeathMenuUI.SetActive(false);
        Time.timeScale= 1f;
    }

    private IEnumerator ShieldActivation()
    {
        _shieldActivity = true;
        ShieldOnPlayer.SetActive(true);
        yield return new WaitForSeconds(10);
        _shieldActivity = false;
        ShieldOnPlayer.SetActive(false);
    }
    private IEnumerator SpeedBurst()
    {
        _moveSpeed +=500;
        _shieldActivity = true;
        ShieldOnPlayer.SetActive(true);
        yield return new WaitForSeconds(2);
        _moveSpeed -=500;
        _shieldActivity = false;
        ShieldOnPlayer.SetActive(false);
    }
    private void ExplosionActivation()
    {
       GameObject _explosionRef = (GameObject)Instantiate(_explosion);
      _explosionRef.transform.position = new Vector3(transform.position.x+5, transform.position.y+5, transform.position.z); 
    }
}
