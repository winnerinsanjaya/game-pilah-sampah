using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript Instance; // init instance

    public int Score;

    public Text textScore;



    private void Awake()
    {
        Instance = this;
    }

   
    void Start()
    {
        //define the score when the script run
        Score = 0;
    }


    public void Benar()
    {
        //if he collision of the box with the sampah match the tag, score +10
        Score += 10;
    }
    public void Salah()
    {
        //if he collision of the box with the sampah doesnt match the tag, score -15
        Score -= 15;
    }

    void Update()
    {
        //update the score text
        textScore.text = "SCORE : " + Score.ToString();

        //if the game score below zero, it will go to game over scene
        if(Score < 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }


    //button funtion to play again
    public void OnPressedPlayAgain()
    {

        //load the game scene
        SceneManager.LoadScene("GameScene");
    }
}
