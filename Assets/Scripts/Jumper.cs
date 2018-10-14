using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MoveController {
    public float jumpPower;
    private bool jumping;

    void Update()
    {
        myrigidbody.velocity = new Vector2(speed, myrigidbody.velocity.y);
        if (Input.GetKeyDown("space") && !jumping)
        {
            Action();
        }
    }

    public override void Action()
    {
        myrigidbody.velocity += new Vector2(0, jumpPower);
        jumping = true;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        jumping = false;
    }
}
