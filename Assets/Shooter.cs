using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    public float reloading = 5.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        InvokeRepeating("Projectile", reloading, reloading);
    }

    void Projectile()
    {
        Vector3 spawnPosition = new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z);

        Instantiate(bullet, spawnPosition, Quaternion.identity);
    }
}
