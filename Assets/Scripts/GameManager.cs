using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int money;
    public int Money
    {
        get
        {
            return money;
        }
        set
        {
            money = value;
        }
    }


    private int typeOfTower;
    public int TypeOfTower { get { return typeOfTower; } set { typeOfTower = value; } }
    
    public List<Enemy> enemies=new List<Enemy>();
    public List<Tower> towers=new List<Tower>();

    [SerializeField]
    private int towerCostMilk = default;
    public int TowerCostMilk => towerCostMilk;
    
    [SerializeField]

    private int towerCostEgg = default;
    public int TowerCostEgg => towerCostEgg;

    [SerializeField]
    GameObject killScreen;

    private void Start()
    {
        typeOfTower = 1;
    }
    public void GameOver()
    {
        Time.timeScale = 0;
        killScreen.SetActive(true);
    }
    public void ResetStat()
    {
        money = 100;

    }

}



