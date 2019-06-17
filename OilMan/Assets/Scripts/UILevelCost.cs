using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILevelCost : MonoBehaviour
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
        GetComponent<Text>().text = ((int)myOilPlot.CalcLevelCost()).ToString();
    }
}
