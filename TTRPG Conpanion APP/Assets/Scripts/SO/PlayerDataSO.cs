using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Create Player Data", order = 1)]
public class PlayerDataSO : ScriptableObject
{
    public int numOfPosDice;
    public int numOfNutralDice;
    public int numOfNegDice;

    public int posCons;

    public int posDiceResult;


}
