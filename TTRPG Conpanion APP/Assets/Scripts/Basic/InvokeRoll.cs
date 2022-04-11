using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRoll : MonoBehaviour
{
    public GameEvent rollDiceEvent;
    public GameEvent setRes;
    public PlayerDataSO pD;

    public void rollDice()
    {
        pD.posDiceResult = 0;
        pD.negDiceResult = 0;
        rollDiceEvent?.Invoke();
        setRes?.Invoke();
    }
}
