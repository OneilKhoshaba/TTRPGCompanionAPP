using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AttributeManager : MonoBehaviour
{
    public PlayerDataSO pD;
    public TMP_Text atDisplay;
    public GameEvent spawnDice;
    public enum AtType { brawl, Ranged, Brawn, Finesse, Ingenunity, Mental, Social, Awarness};
    public AtType Attribue;

    public int atValue;

    void Start()
    {
        
    }

    void Update()
    {
        if(Attribue == AtType.brawl)
        {
            atValue = pD.psBrawl;
            atDisplay.text = "" + pD.psBrawl;
        }

        if (Attribue == AtType.Ranged)
        {
            atValue = pD.psRanged;
            atDisplay.text = "" + pD.psRanged;
        }

        if (Attribue == AtType.Brawn)
        {
            atValue = pD.psBrawn;
            atDisplay.text = "" + pD.psBrawn;
        }

        if (Attribue == AtType.Finesse)
        {
            atValue = pD.psFinesse;
            atDisplay.text = "" + pD.psFinesse;
        }

        if (Attribue == AtType.Ingenunity)
        {
            atValue = pD.psIngenuity;
            atDisplay.text = "" + pD.psIngenuity;
        }

        if (Attribue == AtType.Mental)
        {
            atValue = pD.psMental;
            atDisplay.text = "" + pD.psMental;
        }

        if (Attribue == AtType.Social)
        {
            atValue = pD.psSocial;
            atDisplay.text = "" + pD.psSocial;
        }

        if (Attribue == AtType.Awarness)
        {
            atValue = pD.psAwarness;
            atDisplay.text = "" + pD.psAwarness;
        }
    }

    public void addAtDice()
    {
        for(int i = 0; i < atValue; i++)
        {
            spawnDice?.Invoke();
        }
    }

    public void IncreaseStat()
    {
        if (Attribue == AtType.brawl)
        {
            pD.psBrawl++;
        }

        if (Attribue == AtType.Ranged)
        {
            pD.psRanged++;
        }

        if (Attribue == AtType.Brawn)
        {
            pD.psBrawn++;
        }

        if (Attribue == AtType.Finesse)
        {
            pD.psFinesse++;
        }

        if (Attribue == AtType.Ingenunity)
        {
            pD.psIngenuity++;
        }

        if (Attribue == AtType.Mental)
        {
            pD.psMental++;
        }

        if (Attribue == AtType.Social)
        {
            pD.psSocial++;
        }

        if (Attribue == AtType.Awarness)
        {
            pD.psAwarness++;
        }
    }

    public void DecreaseStat()
    {
        if (Attribue == AtType.brawl)
        {
            pD.psBrawl--;
        }

        if (Attribue == AtType.Ranged)
        {
            pD.psRanged--;
        }

        if (Attribue == AtType.Brawn)
        {
            pD.psBrawn--;
        }

        if (Attribue == AtType.Finesse)
        {
            pD.psFinesse--;
        }

        if (Attribue == AtType.Ingenunity)
        {
            pD.psIngenuity--;
        }

        if (Attribue == AtType.Mental)
        {
            pD.psMental--;
        }

        if (Attribue == AtType.Social)
        {
            pD.psSocial--;
        }

        if (Attribue == AtType.Awarness)
        {
            pD.psAwarness--;
        }
    }
}
