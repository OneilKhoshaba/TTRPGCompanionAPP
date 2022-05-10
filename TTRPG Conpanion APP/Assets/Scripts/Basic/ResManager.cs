using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public void GivePosCon()
    {
        if(playerSheet1.activeInHierarchy == true)
        {
            player1.posCons++;
        }

        if (playerSheet2.activeInHierarchy == true)
        {
            player2.posCons++;
        }

        if (playerSheet3.activeInHierarchy == true)
        {
            player3.posCons++;
        }

        if (playerSheet4.activeInHierarchy == true)
        {
            player4.posCons++;
        }
    }
    
}
