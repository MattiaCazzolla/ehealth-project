using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Goback_scene : MonoBehaviour
{
    public int score;
    private GameManager gameManager;
    public TextMeshProUGUI scoreText;

   private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Menu");
        if ((SceneManager.GetActiveScene().buildIndex == 8) || (SceneManager.GetActiveScene().buildIndex == 9))
        {
            gameManager.score = 0;
        }
    }
}
