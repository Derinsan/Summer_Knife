using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TargetMove : MonoBehaviour
{
    [SerializeField] private float _speedMove;

    private void Start()
    {
        _speedMove = -0.16f;
    }

    private void FixedUpdate()
    {
        Move();

        if (transform.position.y >= 3.25f)
        {
            _speedMove = -0.16f;
        }
        else if (transform.position.y <= -3.25f)
        {
            _speedMove = 0.16f;
        }
    }

    private void Move()
    {
        transform.Translate(0, _speedMove, 0);
    }
}
