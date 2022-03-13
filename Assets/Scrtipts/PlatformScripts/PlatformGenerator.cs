using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{

    public GameObject platform; 
    public Transform generationPoint;
    public float distanceBetween;
    
    int platformSelector;
    float[] platformsWidth;
    public PlatformManager[] platformsM; 



    void Start()
    {
        platformsWidth = new float[platformsM.Length];

        for (int i = 0; i< platformsM.Length; i++)
        {
            platformsWidth[i] = platformsM[i].platform.GetComponent<BoxCollider2D>().bounds.extents.x*2;
        }
    }

    
    void Update()
    {
        if(transform.position.x < generationPoint.position.x)
        {
            platformSelector = Random.Range(0, platformsM.Length);

            transform.position = new Vector3(transform.position.x + platformsWidth[platformSelector] + distanceBetween, transform.position.y, transform.position.z);

            GameObject newPlatform = platformsM[platformSelector].GetPlatform();
            
            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);      
        }
    }
}
