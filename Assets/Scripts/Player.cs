using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TowerDefence.Managers;

namespace TowerDefence.Player
{
    public class Player : MonoBehaviour
    {
        private GameManager gameManager;
        private void Start()
        {
            gameManager = FindObjectOfType<GameManager>();
        }
    }
  
}



        