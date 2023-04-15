using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeHealth : MonoBehaviour
{
    public int health;
    public Transform _pointSpawnPlayer;
    [SerializeField] private Image[] _healthImage;
    public static int numberOfLives = 3;
    [SerializeField] private GameObject _panelGameOverLose;

    private void Start()
    {
        _panelGameOverLose.SetActive(false);
        numberOfLives = 3;
    }

    private void FixedUpdate()
    {
        if (numberOfLives <= 0)
        {
            _panelGameOverLose.SetActive(true);
        }
    }

    private void Update()
    {
        if (health > numberOfLives)
        {
            health = numberOfLives;
        }
        
        for (int i = 0; i < _healthImage.Length; i++)
        {
            if (i < numberOfLives)
            {
                _healthImage[i].enabled = true;
            }
            else
            {
                _healthImage[i].enabled = false;
            }
        }
    }
}
