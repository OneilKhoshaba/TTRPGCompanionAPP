using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessTracker : MonoBehaviour
{
    public GameObject s;
    public GameObject a;
    public GameObject n;
    public GameObject d;
    public GameObject f;
    public PlayerDataSO pD;
    public int finalRes;

    // Update is called once per frame
    void Update()
    {
        int finalRes = pD.posDiceResult - pD.negDiceResult;
        if(finalRes > 2)
        {
            s.SetActive(false);
        }

        if (finalRes == 1 || finalRes == 2)
        {
            a.SetActive(false);
        }

        if (finalRes == 0)
        {
            n.SetActive(false);
        }

        if (finalRes == -1 || finalRes == -2)
        {
            d.SetActive(false);
        }

        if (finalRes <= -3)
        {
            f.SetActive(false);
        }
    }

    public void resetTracker()
    {
        s.SetActive(true);
        a.SetActive(true);
        n.SetActive(true);
        d.SetActive(true);
        f.SetActive(true);
    }


}
