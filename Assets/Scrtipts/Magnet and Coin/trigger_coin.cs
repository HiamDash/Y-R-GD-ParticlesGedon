using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_coin : MonoBehaviour
{
    public float maTime = 10f;
    float timelEFT;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("magnet"))
        {
            
            coin_script.magnetActive = true;
            other.gameObject.SetActive(false);




        }
        if (other.gameObject.CompareTag("coin"))
        {
             other.gameObject.SetActive(false);
            //coin_script.magnetActive = true;
        }
    }
}
