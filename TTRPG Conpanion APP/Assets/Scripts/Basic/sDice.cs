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



    public void spawnDice()
    {
        pD.numOfPosDice++;
        Instantiate(Dice, diceContainer.transform);
        diceNumText.text = "Pos Dice " + pD.numOfPosDice;
    }

    public void spawnNeutDice()
    {
        pD.numOfNutralDice++;
        Instantiate(Dice, diceContainer.transform);
        diceNumText.text = "Neutral Dice " + pD.numOfNutralDice;
    }

    public void spawnNegDice()
    {
        pD.numOfNegDice++;
        Instantiate(Dice, diceContainer.transform);
        diceNumText.text = "Neg Dice " + pD.numOfNegDice;
    }

}
