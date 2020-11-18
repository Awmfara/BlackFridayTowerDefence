using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefence.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance = null;

        #region Variables
        [Header("Player Variables")]
        [SerializeField, Tooltip("Player Health"), Range(0, 100)]
        private int initialPlayerHealth = 100;
        private int playerHealth = 100;
        [SerializeField, Tooltip("Player Level")]
        private int initialPlayerLevel = 0;
        private int playerLevel = 0;
        [SerializeField, Tooltip("XP Points")]
        private int initialXp = 0;
        private int xp = 0;
        [SerializeField, Tooltip("Currency")]
        private int initialCurrency;
        private int currency = 0;



        #endregion
        #region Public Properties
        public int PlayerHealth { get { return playerHealth; } set { playerHealth = value; } }
        public int PlayerLevel { get { return playerLevel; } set { playerLevel = value; } }
        public int XP { get { return xp; } set { xp = value; } }
        public int Currency { get { return currency; } set { currency = value; } }
        #endregion
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if (instance != this)
            {
                Destroy(gameObject);
                return;
            }
            DontDestroyOnLoad(this);
        }
        private void Start()
        {
            InitialSettings();
        }
        void InitialSettings()
        {
            playerHealth = initialPlayerHealth;
            playerLevel = initialPlayerLevel;
            xp = initialXp;
            currency = initialCurrency;
        }
    }
}