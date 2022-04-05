using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RollDice : MonoBehaviour
{
    public PlayerDataSO pD;
    public int posRollAmount;
    public TMP_Text resText;

    public void rollPosDice()
    {
        posRollAmount = pD.numOfPosDice;
        while (posRollAmount > 0)
        {
            int diceRis = Random.Range(1, 6);
            posRollAmount--;
            //rollResult();
            Debug.Log(diceRis);
            //string diceString = diceRis.ToString();
            resText.text = diceRis.ToString();

        }
      
    }

    //void rollResult()
    //{
    //    if(diceRis = 1)
    //    {

    //    }
    //}


}
