using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResManager : MonoBehaviour
{
    public PlayerDataSO player1;
    public PlayerDataSO player2;
    public PlayerDataSO player3;
    public PlayerDataSO player4;
    [Space(30)]
    public GameObject playerSheet1;
    public GameObject playerSheet2;
    public GameObject playerSheet3;
    public GameObject playerSheet4;
    [Space(30)]
    public PlayerDataSO negCons;
    public TMP_Text negConText;

    public void Update()
    {
        negConText.text = "" + negCons.negCons;
    }

    public void GivePosCon()
    {
        if(playerSheet1.activeInHierarchy == true)
        {
            if(player1.posCons < 5)
            {
                player1.posCons++;
            }
            
        }

        if (playerSheet2.activeInHierarchy == true)
        {
            if (player2.posCons < 5)
            {
                player2.posCons++;
            }
        }

        if (playerSheet3.activeInHierarchy == true)
        {
            if (player3.posCons < 5)
            {
                player3.posCons++;
            }
        }

        if (playerSheet4.activeInHierarchy == true)
        {
            if (player4.posCons < 5)
            {
                player4.posCons++;
            }
        }
    }
    
}
