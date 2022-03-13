using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectDestroyer : MonoBehaviour
{
    public GameObject destroyPoint;

    void Start()
    {
        destroyPoint = GameObject.Find("DestroyPoint");    
    }

    
    void Update()
    {
        if(transform.position.x < destroyPoint.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}