using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceResult : MonoBehaviour
{
    public Rigidbody rb;
    public int diceCount;
    bool isDiceReadable = false;

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.magnitude > 0)
        {
            isDiceReadable = true;
        }

        if(rb.velocity.magnitude == 0 & isDiceReadable)
        {
            regularDiceCount();
        }
    }

    void regularDiceCount()
    {
        if (Vector3.Dot(transform.forward, Vector3.up) > 0.6f)
            diceCount = 1;
        if (Vector3.Dot(-transform.forward, Vector3.up) > 0.6f)
            diceCount = 6;
        if (Vector3.Dot(transform.up, Vector3.up) > 0.6f)
            diceCount = 2;
        if (Vector3.Dot(-transform.up, Vector3.up) > 0.6f)
            diceCount = 5;
        if (Vector3.Dot(transform.right, Vector3.up) > 0.6f)
            diceCount = 4;
        if (Vector3.Dot(-transform.right, Vector3.up) > 0.6f)
            diceCount = 3;
        Debug.Log("diceCount :" + diceCount);
    }
}
