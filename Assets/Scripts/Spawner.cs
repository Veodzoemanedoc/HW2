using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _sphere;
    [SerializeField] private GameObject _spawnPoint;
    [SerializeField] private GameObject _trigger;

    private void OnTriggerEnter()
    {
       
        if (_trigger)
        {
            GameObject b = Instantiate(_sphere, _spawnPoint.transform.position, _sphere.transform.rotation);
        }
    }
}
