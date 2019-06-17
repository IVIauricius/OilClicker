using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tapper : MonoBehaviour
{
    private GameController gameController;
    public int tapPower;
    public int gemChance;

    private void Awake()
    {
        // Get a reference to the script.
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TapperTapped()
    {
        // Update the game's money.
        gameController.totalMoney += tapPower;
    }

    public void GemGenerator()
    {
        // Out of X add a gem to the player.
        if(Random.Range(0, gemChance) == 0)
        {
            gameController.totalGems += 1;
        }
    }

    void CreateFloaty()
    {

    }
}
