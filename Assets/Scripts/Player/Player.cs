using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D myRigibody;

    public Vector2 friction = new Vector2(.1f, 0);

    public float speed;
    public float speedRun;

    public float forceJump = 2;

    private float _currentSpeed;

    private bool _isRunning = false;

    private void Update()
    {
        HandleMoviment();
        HandleJump();
    }

    private void HandleMoviment()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            _currentSpeed = speedRun;
        else
            _currentSpeed = speed;

        if (Input.GetKey(KeyCode.A))
        {
            myRigibody.velocity = new Vector2(-_currentSpeed, myRigibody.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            myRigibody.velocity = new Vector2(_currentSpeed, myRigibody.velocity.y);
        }

        if(myRigibody.velocity.x < 0)
        {
            myRigibody.velocity += friction;
        }
        else if (myRigibody.velocity.x > 0)
        {
            myRigibody.velocity -= friction;
        }
    }

    

    private void HandleJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigibody.velocity = Vector2.up * forceJump;
        }
    }
}
