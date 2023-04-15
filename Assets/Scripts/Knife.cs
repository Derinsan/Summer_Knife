using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    private Rigidbody2D _rigidbody2D;
    public static bool _targetDestroy;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _targetDestroy = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && KnifeHealth.numberOfLives >= 1)
        {
            _rigidbody2D.velocity += new Vector2(_speedMove, 0);
        }
    }

    private void FixedUpdate()
    {
        if (transform.position.x >= 15f)
        {
            KnifeControl._isKnifeDestroy = true;
            Destroy(gameObject);
            KnifeHealth.numberOfLives--;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            _targetDestroy = true;
            KnifeControl._isKnifeDestroy = true;
            Score.score++;
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
