using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoveLeft : MonoBehaviour
{
  public float moveSpeed;
  public Vector2 movement;

  // Update is called once per frame
  void Update()
  {
      movement.x = -1;
      transform.Translate(movement * moveSpeed * Time.deltaTime);
  }

  void OnBecameInvisible(){
    Destroy(this.gameObject);
  }
}
