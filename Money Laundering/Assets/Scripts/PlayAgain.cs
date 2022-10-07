using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    void OnClick(){
      Debug.Log("Yoo");
      SceneManager.LoadScene("SampleScene");
    }
}
