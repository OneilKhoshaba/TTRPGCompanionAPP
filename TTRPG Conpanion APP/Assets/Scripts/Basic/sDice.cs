using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sDice : MonoBehaviour
{
    public GameObject Dice;
    public GameObject diceContainer;
    public PlayerDataSO pD;
    public TMP_Text diceNumText;

    public void Update()
    {
        diceNumText.text = "Pos Dice " + pD.numOfPosDice;
        diceNumText.text = "Neg Dice " + pD.numOfNegDice;
    }

    public void spawnDice()
    {
        pD.numOfPosDice++;
        Instantiate(Dice, diceContainer.transform);

    }

    public void spawnNeutDice()
    {
        pD.numOfNutralDice++;
        Instantiate(Dice, diceContainer.transform);

    }

    public void spawnNegDice()
    {
        pD.numOfNegDice++;
        Instantiate(Dice, diceContainer.transform);

    }

}
