using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tower : MonoBehaviour
{
 
    [SerializeField]
    Blocks block;
    [SerializeField]
    private int towerHealth;
    [SerializeField]
    private int towerStrength;
    [SerializeField]
    private int towerCost;
    public abstract TowerTypes TowerTypes { get; }

    private void Awake()
    {
        block = GetComponentInParent<Blocks>();
       
    }
    private void Start()
    {
       
    }
    private void OnMouseDown()
    {
        if (block!=null)
        {
            Debug.Log("Tower Clicked");
            block.DestroyTower();
        }

    }
 
}
