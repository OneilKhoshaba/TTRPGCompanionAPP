using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiceAmount : MonoBehaviour
{
    public PlayerDataSO pD;
    public TMP_Text diceNumText;


    public void addPosDice()
    {
        pD.numOfPosDice++;
        diceNumText.text = "Pos Dice " + pD.numOfPosDice;
    }

    public void subPosDice()
    {
        pD.numOfPosDice--;
        diceNumText.text = "Pos Dice " + pD.numOfPosDice;
    }

    public void addNeutDice()
    {
        pD.numOfNutralDice++;
        diceNumText.text = "Neutral Dice " + pD.numOfNutralDice;
    }

    public void subNeutDice()
    {
        pD.numOfNutralDice--;
        diceNumText.text = "Neutral Dice " + pD.numOfNutralDice;
    }

    public void addNegDice()
    {
        pD.numOfNegDice++;
        diceNumText.text = "Neg Dice " + pD.numOfNegDice;
    }

    public void subNegDice()
    {
        pD.numOfNegDice--;
        diceNumText.text = "Neg Dice " + pD.numOfNegDice;
    }


}
