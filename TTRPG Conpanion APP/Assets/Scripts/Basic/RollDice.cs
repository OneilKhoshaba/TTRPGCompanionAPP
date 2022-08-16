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
    public GameEvent posConEvent;
    public float diceNumber;

    public int diceValue;
    [Space(30)]
    public PlayerDataSO player1;
    public PlayerDataSO player2;
    public PlayerDataSO player3;
    public PlayerDataSO player4;

    public GameObject playerSheet1;
    public GameObject playerSheet2;
    public GameObject playerSheet3;
    public GameObject playerSheet4;


    public enum DiceType { pos, neut, neg };
    public DiceType dType;
    private void Awake()
    {
        if (dType == DiceType.pos)
        {
            diceNumber = pD.numOfPosDice;
        }

        if (dType == DiceType.neut)
        {
            diceNumber = pD.numOfNutralDice;
        }

        if (dType == DiceType.neg)
        {
            diceNumber = pD.numOfNegDice;
        }
    }
    public void rollPosDiceV2()
    {

            int diceRis = Random.Range(1, 7);
            Debug.Log(diceRis);
            if (diceRis == 1 || diceRis == 2 || diceRis == 3)
            {
                pD.posDiceResult++;
                posResText.text = "1";
            }
            if (diceRis == 6 || diceRis == 5 || diceRis == 4 )
            {
                pD.posDiceResult += 2;
                posResText.text = "2";
            }

    }

    public void desPosDice()
    {
        if (diceNumber == pD.numOfPosDice)
        {
            Destroy(gameObject);
        }
    }
    public void clearDice()
    {
        Destroy(gameObject);
    }


    public void rollNeutDice()
    {
            int diceRis = Random.Range(1, 7);
            Debug.Log(diceRis);
            //resText.text = diceRis.ToString();
            if (diceRis == 1 || diceRis == 2)
            {
                pD.negDiceResult++;
                posResText.text = "-1";
            }
            if (diceRis == 3 || diceRis == 4)
            {
                pD.posCons++;
                posResText.text = "FallOut";
            }
            if (diceRis == 5 || diceRis == 6)
            {
                pD.posDiceResult++;
                posResText.text = "1";
            }

    }

    public void desNeutDice()
    {
        if (diceNumber == pD.numOfNutralDice)
        {
            Destroy(gameObject);
        }
    }

    public void rollNegDiceV2()
    {
            int diceRis = Random.Range(1, 7);
            Debug.Log(diceRis);

            if (diceRis == 3 || diceRis == 1 || diceRis == 2)
            {
                pD.negDiceResult++;
                posResText.text = "-1";
            }
            if (diceRis == 6 || diceRis == 4 || diceRis == 5)
            {
                pD.negDiceResult+=2;
                posResText.text = "-2";
            }

    }

    public void desNegDice()
    {
        if (diceNumber == pD.numOfNegDice)
        {
            Destroy(gameObject);
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
