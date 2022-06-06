using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRoll : MonoBehaviour
{
    public GameEvent rollDiceEvent;
    public GameEvent setRes;
    public GameEvent clearDiceEvent;
    public PlayerDataSO pD;

    public void rollDice()
    {
        pD.posDiceResult = 0;
        pD.negDiceResult = 0;
        rollDiceEvent?.Invoke();
        setRes?.Invoke();
    }

    public void clearDice()
    {
        clearDiceEvent?.Invoke();
        pD.numOfNegDice = 0;
        pD.numOfPosDice = 0;
    }
}
