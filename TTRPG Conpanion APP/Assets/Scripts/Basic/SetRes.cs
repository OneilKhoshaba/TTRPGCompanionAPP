using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetRes : MonoBehaviour
{
    public TMP_Text resText;
    public PlayerDataSO pD;
    private int finalRes;

    public void setResText()
    {
        finalRes = pD.posDiceResult - pD.negDiceResult;
        resText.text = "" + finalRes;
    }
}
