using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddleMovement : MonoBehaviour
{
    public float scaler;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float paddleMove = Input.GetAxis("LeftP");
        transform.position += new Vector3(0, paddleMove, 0) * scaler;
        float yPos = Mathf.Clamp(transform.position.y, -5.0f, 5.0f);
        transform.position = new Vector3(transform.position.x, yPos, 0);

    }
}
