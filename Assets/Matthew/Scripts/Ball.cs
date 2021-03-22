using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    #region Main Variables
    public GameObject gameController;
    Rigidbody2D rb2;
    public float initSpeed; //Speed ball starts at
    public float addPercentage; //Percentage of current speed added whenever ball hits something, 1.1 means 10% added

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        rb2 = gameObject.GetComponent<Rigidbody2D>();

        int coinFlip = Random.Range(1, 3);
        if (coinFlip == 1)
        {
            rb2.velocity = new Vector2(initSpeed, initSpeed);
        }
        if (coinFlip == 2)
        {
            rb2.velocity = new Vector2(initSpeed, -initSpeed);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Hit something");
        if (collision.gameObject.tag == "Wall")
        {
            rb2.velocity = Vector3.Reflect(rb2.velocity, Vector3.up);
            rb2.velocity = rb2.velocity * addPercentage;
        }
        if (collision.gameObject.tag == "Paddle")
        {
            rb2.velocity = Vector3.Reflect(rb2.velocity, collision.gameObject.transform.right);
            rb2.velocity = rb2.velocity * addPercentage;
        }
        if (collision.gameObject.tag == "Goal")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Powerup")
        {
            gameController.GetComponent<MatthewEffects>().PowerUp(collision.gameObject.name);
        }
    }
}
