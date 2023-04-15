using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Target : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    [SerializeField] private GameObject _targetPrefab;
    [SerializeField] private Transform[] _pointSpawnTarget;
    [SerializeField] private AudioSource _audioFlick;

    private void FixedUpdate()
    {
        if (Knife._targetDestroy == true)
        {
            _audioFlick.Play();
            Quaternion spawnRotation = Quaternion.Euler(0, 45, 0);
            Instantiate(_targetPrefab, _pointSpawnTarget[Random.Range(0, _pointSpawnTarget.Length)].position, spawnRotation);
            Knife._targetDestroy = false;
        }
    }
}
