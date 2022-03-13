using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float jetpackForce;

    Rigidbody2D rb;
    Collider2D myCollider;

  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();

    }
 
    void FixedUpdate()
    {
        bool jetpackActive = Input.GetButton("Jump");
        if (jetpackActive)
        {
            rb.AddForce(new Vector2(0, jetpackForce));
        }
    }
    
}
