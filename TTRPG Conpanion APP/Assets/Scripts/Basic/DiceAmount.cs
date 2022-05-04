using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiceAmount : MonoBehaviour
{
    public PlayerDataSO pD;
    public TMP_Text diceNumText;
    public GameEvent destroyPosDice;
    public GameEvent destroyNeutDice;
    public GameEvent destroyNegDice;



    public void addPosDice()
    {
        pD.numOfPosDice++;
        diceNumText.text = "Pos Dice " + pD.numOfPosDice;
    }

    public void subPosDice()
    {
        if(pD.numOfPosDice > 0)
        {
            destroyPosDice?.Invoke();
            pD.numOfPosDice--;
            diceNumText.text = "Pos Dice " + pD.numOfPosDice;
        }

    }

    public void addNeutDice()
    {
        pD.numOfNutralDice++;
        diceNumText.text = "Neutral Dice " + pD.numOfNutralDice;
    }

    public void subNeutDice()
    {
        if(pD.numOfNutralDice > 0)
        {
            destroyNeutDice?.Invoke();
            pD.numOfNutralDice--;
            diceNumText.text = "Neutral Dice " + pD.numOfNutralDice;
        }

    }

    public void addNegDice()
    {
        pD.numOfNegDice++;
        diceNumText.text = "Neg Dice " + pD.numOfNegDice;
    }

    public void subNegDice()
    {
        if(pD.numOfNegDice > 0)
        {
            destroyNegDice?.Invoke();
            pD.numOfNegDice--;
            diceNumText.text = "Neg Dice " + pD.numOfNegDice;
        }
    }


}
