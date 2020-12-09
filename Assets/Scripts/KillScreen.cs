using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class KillScreen : MonoBehaviour
{
    
    GameManager gameManager;
    [SerializeField]
    string loadScene = "gameScene";
    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Time.timeScale = 1;
            gameManager.ResetStat();
            SceneManager.LoadScene(loadScene);
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
#if UNITY_EDITOR // if In Unity Editor
            EditorApplication.ExitPlaymode(); //Exits Playmode
#endif
            Application.Quit(); //Quits Application
        }
    }
}
