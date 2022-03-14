using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAddForce : MonoBehaviour
{
    public Rigidbody rb;
    public float minDiceForce;
    public float maxDiceForce;

    public bool left;
    public bool forward;
    public bool right;

    private void Awake()
    {

        if (left == true)
        {
            rb.AddForce(-transform.right * Random.Range(minDiceForce, maxDiceForce));
        }
        if (forward == true)
        {
            rb.AddForce(transform.forward * Random.Range(minDiceForce, maxDiceForce));
        }
        if (right == true)
        {
            rb.AddForce(transform.right * Random.Range(minDiceForce, maxDiceForce));
        }
    }
}
