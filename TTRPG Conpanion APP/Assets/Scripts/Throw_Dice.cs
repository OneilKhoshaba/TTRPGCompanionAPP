using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw_Dice : MonoBehaviour
{
    public Rigidbody rb;
    public float diceForce = 5;
    public float torque;

    private float currentDiceForce = 0;

    private Vector2 mousePosStart, mousePosEnd;

    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        currentDiceForce = 0;
        mousePosStart = new Vector2(0, 0);
        mousePosEnd = new Vector2(0, 0);
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton (0))
        {
            Debug.Log("Roll");
            mousePosStart = Input.mousePosition;
            var dicePos = cam.ScreenToViewportPoint(mousePosStart);
            transform.position = new Vector3(mousePosStart.x, transform.localPosition.y, mousePosStart.y).normalized;
            if (currentDiceForce < diceForce)
                currentDiceForce++;
            else
                currentDiceForce = diceForce;
        }

        if(Input.GetMouseButtonUp(0))
        {
            mousePosEnd = Input.mousePosition;
            var dir = (mousePosEnd - mousePosStart).normalized;
            rb.AddForce(new Vector3(dir.x, 0, dir.y) * currentDiceForce * diceForce);
            rb.AddForce(transform.up * 20, ForceMode.Impulse);
            // float turn = Input.GetAxis("Mouse X") + Input.GetAxis("Mouse Y");
            //rb.AddTorque(transform.up * torque * turn);
            currentDiceForce = 0;
        }
    }
}
