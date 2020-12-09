using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    [SerializeField]
    GameManager gameManager;
    [SerializeField]
    private Text moneyCounter;
    [SerializeField]
    private Text milkPrice, eggPrice;


    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Start()
    {
        moneyCounter.text = "$" + gameManager.Money;
        milkPrice.text = "$" + gameManager.TowerCostMilk;
        eggPrice.text = "$" + gameManager.TowerCostEgg;
    }


    void Update()
    {
        moneyCounter.text = "$" + gameManager.Money;
        milkPrice.text = "$" + gameManager.TowerCostMilk;
        eggPrice.text = "$" + gameManager.TowerCostEgg;
    }
}
