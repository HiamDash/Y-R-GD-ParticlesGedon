using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetGenerator : MonoBehaviour
{
  public float MinX;
  public float MaxX;
  public float MinY;
  public float MaxY;
  public float TimeBetweenSpawnMin;
  public float TimeBetweenSpawnMax;
  public GameObject[] Objects;

  private int _random;
  private float _timeBetweenSpawn;
  private float _spawnTime; 

    void Update()
    {
      _timeBetweenSpawn = Random.Range(TimeBetweenSpawnMin, TimeBetweenSpawnMax);
      if(Time.time > _spawnTime)
      {
        Spawn();
        _spawnTime = Time.time + _timeBetweenSpawn;
      }  
    }

    void Spawn()
    {
    _random = Random.Range(0, Objects.Length);
    float randomX = Random.Range(MinX,MaxX);
    float randomY = Random.Range(MinY,MaxY);
    Instantiate(Objects[_random], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }    
}
