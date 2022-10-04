using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class SetFScore : MonoBehaviour
{


    public TMP_Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + GameHandler.Instance.getScore();
    }
}
