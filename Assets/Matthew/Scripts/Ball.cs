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
    public GameObject ball;

    #endregion
    // Start is called before the first frame update
    void Awake()
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("We hit something cap'n");
        //Debug.Log("Hit something");
        if (collision.gameObject.tag == "Wall")
        {
            
            rb2.velocity = rb2.velocity * addPercentage;
        }
        if (collision.gameObject.tag == "Paddle")
        {
            
            rb2.velocity = rb2.velocity * addPercentage;
        }
        if (collision.gameObject.tag == "Goal")
        {
            if (collision.gameObject.name == "RightGoal")
            {
                gameController.GetComponent<Scorekeeper>().leftScore++;
            }
            else if (collision.gameObject.name == "LeftGoal")
            {
                gameController.GetComponent<Scorekeeper>().rightScore++;
            }
            Destroy(gameObject);
            GameObject b = Instantiate(ball, new Vector3(0,0,0), Quaternion.identity);
            b.GetComponent<Ball>().gameController = gameController;
            b.GetComponent<Ball>().initSpeed = initSpeed;
            b.GetComponent<Ball>().addPercentage = addPercentage;
            b.GetComponent<CircleCollider2D>().enabled = true;
            b.GetComponent<Ball>().enabled = true;
        }
        if (collision.gameObject.tag == "Powerup")
        {
            //gameController.GetComponent<MatthewEffects>().PowerUp(collision.gameObject.name);
        }
    }
}
