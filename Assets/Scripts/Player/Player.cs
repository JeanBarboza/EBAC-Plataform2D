using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D myRigibody;

    public Vector2 velocity;

    public float speed;

    public void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            myRigibody.velocity = new Vector2(-speed, myRigibody.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            myRigibody.velocity = new Vector2(speed, myRigibody.velocity.y);
        }
    }
}
