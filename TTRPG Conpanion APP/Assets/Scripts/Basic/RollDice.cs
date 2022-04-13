using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RollDice : MonoBehaviour
{
    public PlayerDataSO pD;
    public int posRollAmount;
    public int negRollAmount;
    public TMP_Text resText;
    public TMP_Text posResText;
    public GameEvent rollDiceEvent;

    public int diceValue;

    public void rollPosDiceV2()
    {
        if (pD.numOfPosDice >= diceValue)
        {
            int diceRis = Random.Range(1, 7);
            Debug.Log(diceRis);
            //resText.text = diceRis.ToString();
            if (diceRis == 1 || diceRis == 2)
            {
                pD.posCons++;
                posResText.text = "PC";
            }
            if (diceRis == 3 || diceRis == 4 || diceRis == 5)
            {
                pD.posDiceResult++;
                posResText.text = "1";
            }
            if (diceRis == 6)
            {
                pD.posDiceResult += 2;
                posResText.text = "2";
            }
        }
        else
        {
            posResText.text = "";
        }

    }

    public void rollNeutDice()
    {
        if (pD.numOfNutralDice >= diceValue)
        {
            int diceRis = Random.Range(1, 7);
            Debug.Log(diceRis);
            //resText.text = diceRis.ToString();
            if (diceRis == 1)
            {
                pD.negCons++;
                posResText.text = "NC";
            }
            if (diceRis == 2)
            {
                pD.posCons++;
                posResText.text = "PC";
            }
            if (diceRis == 3)
            {
                pD.posDiceResult++;
                posResText.text = "1";
            }
            if (diceRis == 4)
            {
                pD.posDiceResult++;
                posResText.text = "1";
            }
            if (diceRis == 5)
            {
                pD.negDiceResult++;
                posResText.text = "-1";
            }
            if (diceRis == 6)
            {
                pD.negDiceResult++;
                posResText.text = "-1";
            }
        }
        else
        {
            posResText.text = "";
        }

    }

    public void rollNegDiceV2()
    {
        if (pD.numOfNegDice >= diceValue)
        {
            int diceRis = Random.Range(1, 7);
            Debug.Log(diceRis);
            //resText.text = diceRis.ToString();
            if (diceRis == 1)
            {
                pD.negCons++;
                posResText.text = "NC";
            }
            if (diceRis == 2)
            {
                pD.negCons++;
                posResText.text = "NC";
            }
            if (diceRis == 3)
            {
                pD.negDiceResult++;
                posResText.text = "-1";
            }
            if (diceRis == 4)
            {
                pD.negDiceResult++;
                posResText.text = "-1";
            }
            if (diceRis == 5)
            {
                pD.negDiceResult++;
                posResText.text = "-1";
            }
            if (diceRis == 6)
            {
                pD.negDiceResult+=2;
                posResText.text = "-2";
            }
        }
        else
        {
            posResText.text = "";
        }

    }

    //public void rollPosDice()
    //{
    //    pD.posDiceResult = 0;
    //    posRollAmount = pD.numOfPosDice;
    //    while (posRollAmount > 0)
    //    {
    //        int diceRis = Random.Range(1, 7);
    //        posRollAmount--;
    //        Debug.Log(diceRis);
    //        //string diceString = diceRis.ToString();
    //        resText.text = diceRis.ToString();
    //        if(diceRis == 1)
    //        {
    //            pD.posCons++;
    //        }
    //        if (diceRis == 2)
    //        {
    //            pD.posCons++;
    //        }
    //        if (diceRis == 3)
    //        {
    //            pD.posDiceResult++;
    //        }
    //        if (diceRis == 4)
    //        {
    //            pD.posDiceResult++;
    //        }
    //        if (diceRis == 5)
    //        {
    //            pD.posDiceResult++;
    //        }
    //        if (diceRis == 6)
    //        {
    //            pD.posDiceResult += 2;
    //        }
    //    }
    //    posResText.text = "" + pD.posDiceResult;
      
    //}

    //public void rollNegDice()
    //{
    //    //pD.negDiceResult = 0;
    //    negRollAmount = pD.numOfNegDice;
    //    while (negRollAmount > 0)
    //    {
    //        int diceRis = Random.Range(1, 7);
    //        negRollAmount--;
    //        Debug.Log(diceRis);
    //        //string diceString = diceRis.ToString();
    //        //resText.text = diceRis.ToString();
    //        if (diceRis == 1)
    //        {
    //            pD.negCons++;
    //        }
    //        if (diceRis == 2)
    //        {
    //            pD.negCons++;
    //        }
    //        if (diceRis == 3)
    //        {
    //            pD.posDiceResult--;
    //        }
    //        if (diceRis == 4)
    //        {
    //            pD.posDiceResult--;
    //        }
    //        if (diceRis == 5)
    //        {
    //            pD.posDiceResult--;
    //        }
    //        if (diceRis == 6)
    //        {
    //            pD.posDiceResult -= 2;
    //        }
    //    }
    //    posResText.text = "" + pD.negDiceResult;

    //}



}
