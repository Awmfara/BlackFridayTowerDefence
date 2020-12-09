using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    [SerializeField]
    GameObject[] points = default;
    public GameObject[] Points { get { return points; } }
}
