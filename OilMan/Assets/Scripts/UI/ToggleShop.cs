using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleShop : MonoBehaviour
{
    public GameObject myPanel;

    void Awake()
    {
        myPanel = GameObject.Find("PanelShop");
    }

    // Start is called before the first frame update
    void Start()
    {
        myPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleShopButtonPress()
    {
        myPanel.SetActive(!myPanel.activeSelf);
    }
}
