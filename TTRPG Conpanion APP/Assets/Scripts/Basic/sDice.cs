using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sDice : MonoBehaviour
{
    public GameObject Dice;
    public GameObject diceContainer;
    public PlayerDataSO pD;



    public void spawnDice()
    {
        pD.numOfPosDice++;
        Instantiate(Dice, diceContainer.transform);
    }

}
