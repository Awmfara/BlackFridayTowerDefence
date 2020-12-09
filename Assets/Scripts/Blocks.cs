using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{

    GameManager gameManager;
    Tower activatedTower;
    public bool towerActivated;
    [SerializeField]
    GameObject milkPrefab=default;
    [SerializeField]
    GameObject eggPrefab=default;
    GameObject tower;

    private int towerCost;
    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    void Start()
    {
        activatedTower = null;
        towerActivated = false;
        tower = eggPrefab;
    }

    private void OnMouseDown()
    {
        if (towerActivated==false)
        {
            CreateTower();
        }
        else
        {
            DestroyTower();
        }
   
    }

    private void CreateTower()
    {
       
        if (towerCost <= gameManager.Money&&gameManager.Money>0)
        {
            AssignTower();
            Debug.Log("Item Clicked");
            Instantiate(tower, transform);
            activatedTower = GetComponentInChildren<Tower>();
            towerActivated = true;
            gameManager.Money -= towerCost;
            if (gameManager.Money<0)
            {
                gameManager.Money = 0;
            }
        }
        else
        {
            Debug.Log("You are Broke");
        }
      
    }

    public void DestroyTower()
    {
        gameManager.towers.Remove(activatedTower);
        Destroy(activatedTower.gameObject);
        towerActivated = false;
    }
    public void AssignTower()
    {
        if (gameManager.TypeOfTower == 1)
        {
            tower = milkPrefab;
            towerCost = gameManager.TowerCostMilk;
        }
        if (gameManager.TypeOfTower == 2)
        {
            tower = eggPrefab;
            towerCost = gameManager.TowerCostEgg;
        }
       

    }
}
