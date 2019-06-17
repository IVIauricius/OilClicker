using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIIncome : MonoBehaviour
{
    public OilPlot myOilPlot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateText();
    }

    void UpdateText()
    {
        GetComponent<Text>().text = "$" + myOilPlot.currentRate.ToString() + " / " + myOilPlot.timer.ToString() +  " Sec";
    }
}
