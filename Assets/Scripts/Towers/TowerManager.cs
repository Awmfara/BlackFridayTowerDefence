using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    [SerializeField]
    private int towerCost;
    public int TowerCost { get => towerCost; set => TowerCost = value; }

}
