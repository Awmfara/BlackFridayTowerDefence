using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    float counter = default;
    [SerializeField]
    float counterReset = default;
    [SerializeField]
    GameObject enemyPrefab = default;
    [SerializeField]
    GameObject spawnPoint = default;

    private void Update()
    {
        if (counter<=0)
        {
            Instantiate(enemyPrefab,spawnPoint.transform.position,Quaternion.identity);
            counter = counterReset;
        }
        else
        {
            counter -= Time.deltaTime;
        }
    }


}

