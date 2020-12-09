using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    float countdownTime, startingTime = default;
    [SerializeField]
    private GameObject enemy;
    float counter;

    void Start()
    {
        counter = startingTime;
    }

    void Update()
    {
        if (counter<=0)
        {
            counter = countdownTime;
            Instantiate(enemy, this.transform);
        }
        else
        {
            counter -= Time.deltaTime;
        }
    }
}
