using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AttributeManager : MonoBehaviour
{
    public PlayerDataSO pD;
    public TMP_Text atAmount;
    public GameEvent spawnDice;
    public enum AtType { brawl, Ranged, Brawn, Finesse, Ingenunity, Mental, Social, Awarness};
    public AtType Attribue;

    public int atValue;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void addAtDice()
    {
        for(int i = 0; i < atValue; i++)
        {
            spawnDice?.Invoke();
        }
    }
}
