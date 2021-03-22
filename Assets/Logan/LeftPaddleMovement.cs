using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddleMovement : MonoBehaviour
{
    public float scaler;
    public float scaler2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float paddleMove = Input.GetAxis("LeftP");
        float paddleRotate = Input.GetAxis("LeftPR");
        transform.position += new Vector3(0, paddleMove, 0) * scaler;
        float yPos = Mathf.Clamp(transform.position.y, -5.0f, 5.0f);
        transform.position = new Vector3(transform.position.x, yPos, 0);

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * Time.deltaTime * scaler2);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * scaler2);
        }
    }
}
