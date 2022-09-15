using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    public float reloading = 5.0f;

    private float timer = 0.0f;

    //private void Start()
    //{
    //    Invoke("Projectile", reloading);
    //}

    // Update is called once per frame
    void FixedUpdate()
    {
        if(timer > reloading)
        {
            StartCoroutine(Projectile());
            timer = 0.0f;
        }
        timer += Time.deltaTime;
        
    }

    IEnumerator Projectile()
    {
        Vector3 spawnPosition = new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z);

        Instantiate(bullet, spawnPosition, Quaternion.identity);
        yield return new WaitForSeconds(5);
    }

    //void Projectile()
    //{
    //    Vector3 spawnPosition = new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z);

    //    Instantiate(bullet, spawnPosition, Quaternion.identity);
    //}
}
