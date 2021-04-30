using UnityEngine;

public class ShootKiller : MonoBehaviour
{
   [SerializeField] private GameObject _bullet;
   [SerializeField] private float _power;
    [SerializeField] private GameObject _spawnPoint;
    [SerializeField] private GameObject _spawnPoint2;
    [SerializeField] private GameObject _spawnPoint3;
    [SerializeField] private GameObject _spawnPoint4;
    [SerializeField] private GameObject _spawnPoint5;
    [SerializeField] private GameObject _spawnPoint6;
    [SerializeField] private GameObject _spawnPoint7;
    [SerializeField] private GameObject _spawnPoint8;
    [SerializeField] private GameObject _spawnPoint9;
    [SerializeField] private GameObject _spawnPoint10;
    [SerializeField] private GameObject _spawnPoint11;
    [SerializeField] private GameObject _spawnPoint12;
    [SerializeField] private GameObject _spawnPoint13;
    [SerializeField] private GameObject _spawnPoint14;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject b = Instantiate(_bullet, _spawnPoint.transform.position, _bullet.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(Vector3.right * _power, ForceMode.Impulse);
            GameObject bb = Instantiate(_bullet, _spawnPoint2.transform.position, _bullet.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(Vector3.right * _power, ForceMode.Impulse);
            GameObject bbb = Instantiate(_bullet, _spawnPoint3.transform.position, _bullet.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(Vector3.right * _power, ForceMode.Impulse);
            GameObject bbbb = Instantiate(_bullet, _spawnPoint4.transform.position, _bullet.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(Vector3.right * _power, ForceMode.Impulse);
            GameObject bbbbb = Instantiate(_bullet, _spawnPoint5.transform.position, _bullet.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(Vector3.right * _power, ForceMode.Impulse);
            GameObject bbbbbb = Instantiate(_bullet, _spawnPoint6.transform.position, _bullet.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(Vector3.right * _power, ForceMode.Impulse);
            GameObject bbbbbbb = Instantiate(_bullet, _spawnPoint7.transform.position, _bullet.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(Vector3.right * _power, ForceMode.Impulse);
            GameObject bbbbbbbb = Instantiate(_bullet, _spawnPoint8.transform.position, _bullet.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(Vector3.right * _power, ForceMode.Impulse);
            GameObject bbbbbbbbb = Instantiate(_bullet, _spawnPoint9.transform.position, _bullet.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(Vector3.right * _power, ForceMode.Impulse);
            GameObject bbbbbbbbbb = Instantiate(_bullet, _spawnPoint10.transform.position, _bullet.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(Vector3.right * _power, ForceMode.Impulse);
            GameObject bbbbbbbbbbb = Instantiate(_bullet, _spawnPoint11.transform.position, _bullet.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(Vector3.right * _power, ForceMode.Impulse);
            GameObject bbbbbbbbbbbb = Instantiate(_bullet, _spawnPoint12.transform.position, _bullet.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(Vector3.right * _power, ForceMode.Impulse);
            GameObject bbbbbbbbbbbbb = Instantiate(_bullet, _spawnPoint13.transform.position, _bullet.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(Vector3.right * _power, ForceMode.Impulse);
            GameObject bbbbbbbbbbbbbb = Instantiate(_bullet, _spawnPoint14.transform.position, _bullet.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(Vector3.right * _power, ForceMode.Impulse);
        }
        }
    }