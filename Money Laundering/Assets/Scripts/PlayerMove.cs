using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody2D rb;
    public float moveSpeed;
    public float jumpSpeed;
    public Vector2 movement;
    public GameHandler gameHandlerObj;
    public float coinSpawnTime;
    private bool isJumping;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
        if (GameObject.FindWithTag("GameHandler")!=null){
          gameHandlerObj =
          GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
        }
    }



    void Update(){
      movement.x = Input.GetAxis("Horizontal");
      transform.Translate(movement * moveSpeed * Time.deltaTime);
      if (Input.GetKeyDown(KeyCode.UpArrow) && !isJumping){
        rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
        isJumping = true;
      }
    }


    void OnCollisionEnter2D(Collision2D other){
      if(other.gameObject.tag == "ground" || other.gameObject.tag == "Truck"){
        isJumping = false;
      }
    }

    void OnTriggerEnter2D(Collider2D other){
      if (other.tag == "jumpStop"){
        GameObject.FindWithTag("Truck").GetComponent<Collider2D>().enabled
                                                                  = false;
      }
      if(other.tag == "coin"){
        StartCoroutine(CoinPause(other));

      }
      if(other.tag == "CopCar"){
          SceneManager.LoadScene("EndScene");
        }
    }

    void OnTriggerExit2D(Collider2D other){
      if (other.tag == "jumpStop"){
        GameObject.FindWithTag("Truck").GetComponent<Collider2D>().enabled
                                                                  = true;
      }
    }



    IEnumerator CoinPause(Collider2D other){
      other.gameObject.SetActive(false);
      gameHandlerObj.AddScore(1);
      yield return new WaitForSeconds(coinSpawnTime);
      other.gameObject.SetActive(true);
    }
}
