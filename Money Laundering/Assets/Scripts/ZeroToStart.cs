using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroToStart : MonoBehaviour
{
    

    void Awake() {
        GameHandler.Instance.ZeroOut();
    }
}
