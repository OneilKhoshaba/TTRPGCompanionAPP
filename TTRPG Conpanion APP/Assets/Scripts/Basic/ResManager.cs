using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResManager : MonoBehaviour
{
    public CharacterDataSO player1;
    public CharacterDataSO player2;
    public CharacterDataSO player3;
    public CharacterDataSO player4;
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
            if(player1.psPlotArmor < 5)
            {
                player1.psPlotArmor++;
            }
            
        }

        if (playerSheet2.activeInHierarchy == true)
        {
            if (player2.psPlotArmor < 5)
            {
                player2.psPlotArmor++;
            }
        }

        if (playerSheet3.activeInHierarchy == true)
        {
            if (player3.psPlotArmor < 5)
            {
                player3.psPlotArmor++;
            }
        }

        if (playerSheet4.activeInHierarchy == true)
        {
            if (player4.psPlotArmor < 5)
            {
                player4.psPlotArmor++;
            }
        }
    }
    
}
