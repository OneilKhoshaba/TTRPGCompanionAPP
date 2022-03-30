using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw_Dice : MonoBehaviour
{
    
    public float diceForce = 5;
    public float torque;
    Vector3 mousePos = Vector3.right;
    Vector3 previousMouse;
    bool fireDice = false;
    [SerializeField] int frameWait = 4;
    private int timer = 0;
    private Rigidbody rigidBody;
    [SerializeField] float _raycastDistance = 500f;
    [SerializeField] private float yHeight = 0.5f;
    [SerializeField] private float _yIncrease = 0.6f;
    [SerializeField] private LayerMask _raycastMask;
    public float diceCount;
    bool checkDice = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rigidBody.isKinematic = true;
            rigidBody.velocity = Vector3.zero;
            transform.rotation = Quaternion.LookRotation(Vector3.forward);
            MoveDiceWithMouseVersion2();
        }
        if (Input.GetMouseButtonUp(0))
        {
            fireDice = true;
            
        }
        //if(checkDice == true )
        //{
        //regularDiceCount();
        //}

    }

    
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(0, 2, 0);
        }
        timer++;
        if (timer > frameWait)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, _raycastDistance, _raycastMask))
            {
                previousMouse = hit.point;
            }
            timer = 0;
        }
        if (fireDice)
        {
            FireDice(mousePos);
        }
    }

    #region FUNCS

    void FireDice(Vector3 lastPos)
    {

        rigidBody.isKinematic = false;
        rigidBody.angularVelocity = new Vector3(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)).normalized * torque;

        Vector3 direction = previousMouse - lastPos;
        float forceAmount = direction.magnitude;
        direction = direction.normalized;
        direction.y += _yIncrease;
        
        rigidBody.AddForce(
            direction * (forceAmount * diceForce * rigidBody.mass));

        fireDice = false;
    }
    
    void MoveDiceWithMouseVersion2()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, _raycastDistance, _raycastMask))
        {
            transform.position = new Vector3(hit.point.x, hit.point.y + yHeight, hit.point.z);
            mousePos = hit.point;
        }
    }
    #endregion

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

