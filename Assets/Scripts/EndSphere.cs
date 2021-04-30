using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSphere : MonoBehaviour
{
    [SerializeField] private GameObject _who;

    private void OnTriggerEnter(Collider other)
    {

    
            _who.SetActive(true);

        
    }
}
