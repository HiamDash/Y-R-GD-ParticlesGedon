using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroler : MonoBehaviour
{
    public float Speed;
    public int PositionOfPatrol;
    public Transform Point;
    public float StoppingDistance;

    private Transform _player;
    private bool _movingRight;
    private bool _chill = false;
    private bool _angry = false;
    private bool _goBack = false;


    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void Update()
    {
        if (Vector2.Distance(transform.position, Point.position) < PositionOfPatrol && _angry == false)
        {
            _chill = true;
        }
        if (Vector2.Distance(transform.position, _player.position) < StoppingDistance)
        {
            _angry = true;
            _chill = false;
            _goBack = false;
        }

        if (Vector2.Distance(transform.position, _player.position) > StoppingDistance)
        {
            _goBack = true;
            _angry = false;
        }

        if (_chill == true)
        {
            Chill();
        }

        else if (_angry == true)
        {
            Angry();
        }
        else if (_goBack == true)
        {
            GoBack();
        }
	}

     void Chill()
     {
        if (transform.position.x > Point.position.x + PositionOfPatrol)
        {
            _movingRight = true;
        }
        else if (transform.position.x < Point.position.x - PositionOfPatrol)
        {
            _movingRight = false;
        }
        if (_movingRight)
        {
            transform.position = new Vector2(transform.position.x + Speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - Speed * Time.deltaTime, transform.position.y);
        }
    }

    void Angry()
    {
        transform.position = Vector2.MoveTowards(transform.position, _player.position, Speed * Time.deltaTime);
    }
    void GoBack()
    {
        transform.position = Vector2.MoveTowards(transform.position, Point.position, Speed * Time.deltaTime);
    }
}