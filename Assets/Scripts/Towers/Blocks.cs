using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public Game game = default;
    private Tower tower;
    public bool createTower;
    public GameObject prefabTower = default;
    private GameObject towerGen;
    private Vector3 blockPosition;
    private Vector3 offset = new Vector3(0, 5, 0);
    public float dist = default;

    private void Awake()
    {
        game = FindObjectOfType<Game>();
        blockPosition = this.transform.position + offset;
    }
    public void CreateTower()
    {
        Instantiate(prefabTower, blockPosition, Quaternion.identity);
    }
    
}
