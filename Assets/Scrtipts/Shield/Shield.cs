using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject shield;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="shield")
        {
            shield.SetActive(true);
            Destroy(collision.gameObject);
        }
    }
}
