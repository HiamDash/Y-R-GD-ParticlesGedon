using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_script : MonoBehaviour
{
    private GameObject game;
    public static bool magnetActive = false;
    void Start()
    {
        game = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()

    {

        if (magnetActive)
        {
            MoveTowardsPlayer();
        }
    }
    void MoveTowardsPlayer()
    {
        transform.position = Vector3.Lerp(a: this.transform.position, b: game.transform.position, t: 3f * Time.deltaTime);
    }
}
