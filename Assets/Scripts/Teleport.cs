using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private GameObject _who;
    [SerializeField] private GameObject _were;
    [SerializeField] private GameObject _trigger;

    private void OnTriggerEnter(Collider other)
    {
        if (_trigger)
        {
            _who.transform.position = _were.transform.position;
        }
    }

}