using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public double totalMoney;
    public double moneyPerSecond;
    public int totalGems;

    //public GameObject TotalMoneyUI;
    public Text MoneyPerSecondUI;
    public Text TotalMoneyUI;
    public Text GemTotal;

    public GameObject[] oilPlots;

    private void Awake()
    {
        // Find the TotalMoney and MoneyPerSecond text objects.
        if (TotalMoneyUI == null)
            TotalMoneyUI = GameObject.Find("TextTotalMoney").GetComponent<Text>();
        if (MoneyPerSecondUI == null)
            MoneyPerSecondUI = GameObject.Find("TextMoneyPerSec").GetComponent<Text>();
        GetAllOilPlots();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        TotalMoneyUI.text = "$" + (int)totalMoney;
        MoneyPerSecondUI.text = "$" + DollarsPerSecond() + " / Sec";
        GemTotal.text = totalGems.ToString();
    }

    void GetAllOilPlots()
    {
        oilPlots = GameObject.FindGameObjectsWithTag("OilPlot");
    }

    int DollarsPerSecond()
    {
        int returnNumber = 0;

        foreach(GameObject oilPlot in oilPlots)
        {
            returnNumber += (int)(oilPlot.GetComponent<OilPlot>().currentRate / oilPlot.GetComponent<OilPlot>().timer);
        }

        return returnNumber;
    }
}
