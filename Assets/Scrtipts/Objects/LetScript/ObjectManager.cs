using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
   public GameObject Object;

   public int ObjectAmount;

   List<GameObject> Objects;

    void Start()
    {
        Objects = new List<GameObject>();

        for(int i = 0; i < ObjectAmount; i++)
        {
            GameObject obj = (GameObject) Instantiate(Object);
            obj.SetActive(false);
            Objects.Add(obj);
        } 
    }
    public GameObject GetPlatform()
    {
        for(int i = 0; i < Objects.Count; i++)
        {
            if(!Objects[i].activeInHierarchy)
            {
                return Objects[i];
            }
        } 
            GameObject obj = (GameObject) Instantiate(Object);
            obj.SetActive(false);
            Objects.Add(obj);
            return obj;
    }
}
