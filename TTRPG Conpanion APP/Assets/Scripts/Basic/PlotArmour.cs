using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlotArmour : MonoBehaviour
{

    public CharacterDataSO pD;
    public TMP_Text plotArmourText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        plotArmourText.text = "Plot Armour: " + pD.psPlotArmor;
    }
}
