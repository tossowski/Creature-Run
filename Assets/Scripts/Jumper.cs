using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MoveController {
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
        if (Input.GetKeyDown("space"))
        {
            Action();
        }

        if (Input.GetKeyDown("w"))
        {
            base.changeCharacter(ToSwitch);
            Destroy(gameObject);
        }

    }

    public override void Action()
    {
        // TODO: get rid of hardcoded -7.9 
        if (!jumping)
        {
            myrigidbody.velocity += new Vector2(0, jumpPower);
            jumping = true;
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
