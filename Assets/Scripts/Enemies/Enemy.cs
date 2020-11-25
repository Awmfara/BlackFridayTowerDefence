using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Waypoints waypoints;

    [SerializeField]
    float speed = default; 
    [SerializeField,Tooltip("Distance from Waypoint till switch")]
    int goalReach=default;
    int currentGoal = default;

    [SerializeField]
    int enemyHealth = default;
    public int EnemyHealth { get{ return enemyHealth; }set { EnemyHealth = value; }  }

    
    private void Start()
    {
        waypoints = FindObjectOfType<Waypoints>();
        if (waypoints ==null)
        {
            Debug.Log("No WayPoints Selected");
        }
    }
    void Update()
    {
        MoveToWaypoints();

    }

    private void MoveToWaypoints()
    {
        if (currentGoal <= waypoints.Points.Length - 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints.Points[currentGoal].transform.position, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, waypoints.Points[currentGoal].transform.position) < goalReach)
            {
                currentGoal++;
            }
        }
        else
        {
            Debug.Log("All Goals Met!");
        }
    }
}
