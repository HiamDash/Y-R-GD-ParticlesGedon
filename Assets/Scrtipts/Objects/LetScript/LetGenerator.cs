using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetGenerator : MonoBehaviour
{
  //  private GameObject Object;
   public float minX;
   public float maxX;
   public float minY;
   public float maxY;
   private float timeBetweenSpawn;
   private float spwanTime; 
   public float tbsMin;
   public float tbsMax;
   
   public GameObject[] Objects;
   private int random;

    // void Start()
    // {
      
   
    // }
    void Update()
    {
      timeBetweenSpawn = Random.Range(tbsMin, tbsMax);
      if(Time.time > spwanTime)
      {
        Spawn();
        spwanTime = Time.time + timeBetweenSpawn;
      }  
    }

    void Spawn()
    {
    random = Random.Range(0, Objects.Length);
    float randomX = Random.Range(minX,maxX);
    float randomY = Random.Range(minY,maxY);
    Instantiate(Objects[random], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
    
}
