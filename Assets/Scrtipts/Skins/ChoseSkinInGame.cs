using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoseSkinInGame : MonoBehaviour
{
public Transform player;

public void Awake()
{
    for(int i = 0;i <  player.childCount;i++)
          player.GetChild(i).gameObject.SetActive(false);

     player.GetChild(PlayerPrefs.GetInt("chosenSkin")).gameObject.SetActive(true);
}
}
