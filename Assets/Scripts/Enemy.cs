using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< Updated upstream
namespace TowerDefence.Enemy
{
    public class Enemy : MonoBehaviour
    {
        #region Variables
        [Header ("General Stats")]
        private int enemyHealth
        #endregion
        #region Public Properties
        #endregion
    }
}
=======
public class Enemy : MonoBehaviour
{
    GameManager gameManager;
    [SerializeField]
    WayPoints waypoints;

    public GameObject enemyDeathball;
   

    [SerializeField]
    float enemySpeed = default;

    [SerializeField, Tooltip("Distance from Waypoint till switch")]
    int currentGoal = default;

    int turningPoint;
    int turningAngle;

    [SerializeField]
    float enemyHealth = default;
    public float EnemyHealth { get { return enemyHealth; } set { enemyHealth = value; } }



    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        waypoints = FindObjectOfType<WayPoints>();
    }
    private void Start()
    {
        enemyDeathball.SetActive(false);
        gameManager.enemies.Add(this);
        enemyHealth = 100;
        currentGoal = 0;
        turningPoint = 0;
        turningAngle = 90;
    }
    private void Update()
    {
        MoveToEnemyWayPoints();
        if (enemyHealth <= 0) 
        {
            Debug.Log("Dead");
            Destroy(this.gameObject);
            gameManager.Money += 100;
        }
  
    }

    private void MoveToEnemyWayPoints()
    {
        if (currentGoal < waypoints.Points.Length)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, waypoints.Points[currentGoal].transform.position, enemySpeed / 10);
   
            if (Vector3.Distance(this.transform.position, waypoints.Points[currentGoal].transform.position) < 1f)
            {
                currentGoal++;
                turningPoint++;
                transform.Rotate(0, turningAngle, 0);

                if (turningPoint>=2)
                {
                    turningAngle = turningAngle * -1;
                    turningPoint = 0;
                }

            }
        }
        else
        {
            gameManager.GameOver();
        }
    }
}


>>>>>>> Stashed changes
