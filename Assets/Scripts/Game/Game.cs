using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    #region Variables
    Ray TouchRay => Camera.main.ScreenPointToRay(Input.mousePosition);
    [SerializeField]
    private Blocks[] blocks;
    [SerializeField]
    private Tower[] towers;

    private float waitTime;

 
    [SerializeField]
    private int money;
    #endregion
    #region Public Properties
    #endregion
    public int Money { get => money; set => Money = value; }
    private void Start()
    {
        blocks = FindObjectsOfType<Blocks>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LeftClick();
        }

    }
    void LeftClick()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            ShiftedClick();
        }
        else
        {
            Blocks block = GetBlocks(TouchRay);
            if (block != null)
            {
                block.CreateTower();
            }

        }

    }
    void ShiftedClick()
    {


        Tower tower = GetTowers(TouchRay);
      
        if (tower != null)
        {
            tower.DestroyTower();
            ShiftedClick();  
        }
        else
        {
            Blocks block = GetBlocks(TouchRay);
            if (block!=null)
            {
                block.createTower = false;
            }
        }


    }

    public Blocks GetBlocks(Ray ray)
    {
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            {

                Transform blockHit = hit.transform;
                Blocks block = hit.collider.GetComponent<Blocks>();
                Debug.Log(block);
                return block;
            }
        }
        return null;
    }
    public Tower GetTowers(Ray ray)
    {
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            {
                Transform towerHit = hit.transform;
                Tower tower = hit.collider.GetComponent<Tower>();
                return tower;
            }
        }
        return null;
    }
}




