using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public Game game = default;
    public Tower tower;
    public bool createTower;
    public GameObject prefabTower = default;
    private Vector3 blockPosition;
    private Vector3 offset = new Vector3(0, 5, 0);

    private void Awake()
    {
        game = FindObjectOfType<Game>();
        blockPosition = this.transform.position + offset;
    }
    private void OnMouseDown()
    {
        if (createTower == false)
        {
            createTower = true;
            Instantiate(prefabTower, blockPosition, transform.rotation);
            game.Money -= tower.TowerCost;
        }
    }
}
