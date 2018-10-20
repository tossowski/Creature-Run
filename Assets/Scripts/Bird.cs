using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MoveController {
    public float jumpPower;

    void Update()
    {
        
        myrigidbody.velocity = new Vector2(speed, myrigidbody.velocity.y);
        if (Input.GetKeyDown("space"))
        {
            Action();
        }

        if (!(myrigidbody.velocity.y >= 0))
        {
            myrigidbody.velocity = new Vector2(speed, -1f);
        }
        Debug.Log(myrigidbody.gravityScale);

        if (Input.GetKeyDown("w"))
        {
            base.changeCharacter(ToSwitch);
            Destroy(gameObject);
        }

    }

    public override void Action()
    {
        if (!(transform.position.y > -7.9f))
        {
            myrigidbody.velocity += new Vector2(0, jumpPower);
        }

    }

}
