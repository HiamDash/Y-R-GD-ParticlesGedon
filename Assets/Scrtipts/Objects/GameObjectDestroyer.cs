using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectDestroyer : MonoBehaviour
{
    public GameObject DestroyPoint;

    void Start()
    {
        DestroyPoint = GameObject.Find("DestroyPoint");    
    }

    void Update()
    {
        if(transform.position.x < DestroyPoint.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}