using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class KnifeControl : MonoBehaviour
{
   public static bool _isKnifeDestroy;
   [SerializeField] private GameObject _knifePrefab;
   [SerializeField] private Transform[] _pointSpawnKnife;

   private void Start()
   {
      _isKnifeDestroy = false;
   }

   private void FixedUpdate()
   {
      if (_isKnifeDestroy == true)
      {
         Quaternion spawnRotation = Quaternion.Euler(0, 0, -90);
         Instantiate(_knifePrefab, _pointSpawnKnife[Random.Range(0, _pointSpawnKnife.Length)].position, spawnRotation);
         _isKnifeDestroy = false;
      }
   }
}
