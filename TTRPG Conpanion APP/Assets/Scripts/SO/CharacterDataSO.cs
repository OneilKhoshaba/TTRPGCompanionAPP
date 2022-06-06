using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "Create Character Data", order = 2)]
public class CharacterDataSO : ScriptableObject
{
    public string playerName;
    [Space(30)]
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
