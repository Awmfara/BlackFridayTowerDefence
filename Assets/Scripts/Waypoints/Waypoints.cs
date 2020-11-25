using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    [SerializeField]
    GameObject[] points=default;
    public GameObject[] Points { get { return points; } }
}
