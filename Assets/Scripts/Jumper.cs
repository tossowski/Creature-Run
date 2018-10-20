using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MoveController {
    public float jumpPower;
    private bool jumping;

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
        if (!(transform.position.y > -7.9f))
        {
            myrigidbody.velocity += new Vector2(0, jumpPower);
            jumping = true;
        }
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        jumping = false;
    }
}
