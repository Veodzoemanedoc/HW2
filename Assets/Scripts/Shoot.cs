using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _power;
    [SerializeField] private GameObject _spawnPoint;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject b = Instantiate(_bullet, _spawnPoint.transform.position, _bullet.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(Vector3.right * _power, ForceMode.Impulse);
        }
    }
}
