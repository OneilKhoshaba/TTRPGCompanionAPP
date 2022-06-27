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
    public enum diceType { pos, neut, neg};
    public diceType dice;

    public void Update()
    {
        if(dice == diceType.pos)
        {
            diceNumText.text = "Pos Dice " + pD.numOfPosDice;
        }

        if (dice == diceType.neut)
        {
            diceNumText.text = "Neut Dice " + pD.numOfNutralDice;
        }

        if (dice == diceType.neg)
        {
            diceNumText.text = "Neg Dice " + pD.numOfNegDice;
        }


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
