using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
    
{
    [SerializeField] private GameObject _enemy;
    private void OnTriggerEnter()
    {
            _enemy.SetActive(false);
    }
}
