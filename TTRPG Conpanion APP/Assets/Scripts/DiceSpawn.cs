using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceSpawn : MonoBehaviour
{
    public GameObject dice;
    public GameObject spawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            spawnDice2();
        }
    }

    void spawnDice2()
    {
        Vector3 objectPOS = spawnLocation.transform.position;
        Instantiate(dice, objectPOS, Quaternion.identity);

    }

    void spawnDice1()
    {
        Vector3 objectPOS = spawnLocation.transform.position;
        Instantiate(dice, objectPOS, Quaternion.Euler(new Vector3(0, 0, Random.Range(-45, 45))));
        
    }
}
