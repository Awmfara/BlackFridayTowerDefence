using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkTower : Tower
{
    public override TowerTypes TowerTypes => TowerTypes.MilkTower;
    GameManager gameManager;

    [SerializeField]
    Transform turret = default, laserBeam = default;

    [SerializeField]
    private Enemy targetedEnemy;
    private bool enemyTargeted;
    [SerializeField]
    private int minimumTargetedDistance;

    private Vector3 startingPosition;

    Vector3 laserBeamScale;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Start()
    {
        startingPosition = turret.transform.position;
        gameManager.towers.Add(this);
        enemyTargeted = false;
    }
    private void Update()
    {
      
        Collider[] hitColliders = Physics.OverlapSphere(this.transform.position, 10);
        foreach (var hitCollider in hitColliders)
        {
            GameObject enet;
            if (hitCollider.gameObject.CompareTag("Enemy"))
            {
                enet = hitCollider.gameObject;
                targetedEnemy=enet.GetComponent<Enemy>();
            }
            
        }

      
        if (targetedEnemy != null)
        {
            if (Vector3.Distance(this.transform.position, targetedEnemy.transform.position) < 35)
            {
                targetedEnemy.enemyDeathball.SetActive(true);
                ShootEnemy();
            }
            else
            {
                targetedEnemy.enemyDeathball.SetActive(false);
                turret.transform.position = startingPosition;
            }
        }
     
      

    }

 
    void ShootEnemy()
    {
        Vector3 point = targetedEnemy.transform.position;
        turret.LookAt(point);
        laserBeam.localRotation = turret.localRotation;

        float d = Vector3.Distance(turret.position, point);
        laserBeamScale.z = d;
        laserBeam.localScale = laserBeamScale;
        laserBeam.localPosition =
        turret.localPosition + 0.5f * d * laserBeam.forward;
        targetedEnemy.EnemyHealth -= 20 * Time.deltaTime;

    }

}
