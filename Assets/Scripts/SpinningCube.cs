using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningCube : MonoBehaviour
{
    Vector3 rotationNums;

    private void Awake()
    {
        rotationNums = new Vector3(RandomNum(), RandomNum(), RandomNum());
    }

    float RandomNum()
    {
        float randomNumber = Random.Range(10f, 100f);
        return randomNumber * Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(rotationNums);
    }
}
