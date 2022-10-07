using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class GameHandler : MonoBehaviour
{
    private int playerScore;
    public static GameHandler Instance;
    // Start is called before the first frame update
    void Start()
    {
        playAgain();

    }

    private void Awake(){
      if (Instance == null){
        Instance = this;
        DontDestroyOnLoad(gameObject);
      }
      else if (Instance != this) {
        Destroy(gameObject);
      }

    }

    public void AddScore(int points){
      playerScore += points;

    }


    public int getScore(){
      return playerScore;
    }


    public void ZeroOut(){
      playerScore = 0;
    }

    public void playAgain(){
      
      SceneManager.LoadScene("SampleScene");
    }

}
