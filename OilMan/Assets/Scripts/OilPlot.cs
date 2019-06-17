using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilPlot : MonoBehaviour
{
    public GameObject gameController;
    public float startPrice;
    public float startRate;
    public float multiplier;
    public float boostMultiplier;
    public float bizbotMultiplier;
    public float profitBoostMultiplier;
    public float timer;
    public float currentLevel;
    public float currentRate;
    public float milestoneMultiplier;

    private float currentMoney;
    private float nextLevelCost;

    private void Awake()
    {
        gameController = GameObject.Find("GameController");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AddMoneyPerFrame();
    }

    void AddMoneyPerFrame()
    {
        gameController.GetComponent<GameController>().totalMoney += CalcMoney();
    }

    float CalcMoney()
    {
        return (currentRate * Time.deltaTime) / timer;
    }

    public void LevelUpButtonClicked()
    {
        currentMoney = (float)gameController.GetComponent<GameController>().totalMoney;
        nextLevelCost = CalcLevelCost();
        if (currentMoney >= nextLevelCost)
        {
            if(CheckMilestone())
            {
                timer /= 4.0f;
            }
            currentLevel += 1.0f;
            currentRate = startRate * currentLevel;
            gameController.GetComponent<GameController>().totalMoney -= nextLevelCost;
        }
    }

    public float CalcLevelCost()
    {
        if (currentLevel > 0.0f)
        {
            // Check if milestone level.
            if (CheckMilestone())
                return (startPrice * (Mathf.Pow(multiplier, currentLevel))) * milestoneMultiplier;
            else
                return (startPrice * (Mathf.Pow(multiplier, currentLevel)));
        }
        else
        {
            return startPrice;
        }
    }

    bool CheckMilestone()
    {
        switch(currentLevel)
        {
            case 24:
                return true;
            case 49:
                return true;
            case 74:
                return true;
            default:
                return false;
        }
    }
}
