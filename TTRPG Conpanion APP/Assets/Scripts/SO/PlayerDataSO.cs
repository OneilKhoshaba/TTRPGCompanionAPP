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
    public int negCons;

    public int posDiceResult;

    public int negDiceResult;

    [Space (30)]

    public int psBrawl;
    public int psRanged;
    public int psBrawn;
    public int psFinesse;
    public int psIngenuity;
    public int psMental;
    public int psSocial;
    public int psAwarness;
    public int psPlotArmor;
}
