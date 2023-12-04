using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    public GameObject _compLasershipPrefab;
    public float _compBulletSpeed = 20f;
    public float fireRate = 0.5f;

    private float nextFireTime = 0f;

    void FixedUpdate()
    {
        if (Time.time > nextFireTime && Input.GetKey(KeyCode.Space))
        {
            GameObject lasership = Instantiate(_compLasershipPrefab, transform.position, transform.rotation);
            Rigidbody2D rb = lasership.GetComponent<Rigidbody2D>();
            rb.velocity = transform.up * _compBulletSpeed;
            nextFireTime = Time.time + fireRate;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.CompareTag("Destroylaser"))
        {
            Destroy(this.gameObject);
        }
    
    }
}