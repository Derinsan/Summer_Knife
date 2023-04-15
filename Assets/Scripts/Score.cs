using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoreGame;
    public static int score;

    private void Start()
    {
        score = 0;
    }

    private void FixedUpdate()
    {
        _scoreGame.text = $"{score}";
    }
}
