using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MoveController {
    public float jumpPower;
    private bool jumping;


    public override void Start()
    {
        base.Start();
        jumping = true;
    }

    void Update()
    {
        
        myrigidbody.velocity = new Vector2(speed, myrigidbody.velocity.y);
        myrigidbody.gravityScale = 4f;
        if (Input.GetKeyDown("space"))
        {
            Action();
        }

        if (!(myrigidbody.velocity.y >= 0))
        {
            myrigidbody.velocity = new Vector2(speed, -0.1f);
        }

        if (Input.GetKeyDown("w"))
        {
            base.changeCharacter(ToSwitch);
            Destroy(gameObject);
        }

    }

    public override void Action()
    {
        if (!jumping)
        {
            jumping = true;
            myrigidbody.velocity += new Vector2(0, jumpPower);
        }

    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            jumping = false;
        }
    }

}
