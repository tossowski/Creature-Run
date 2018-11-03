using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dasher : MoveController {

    private Animator anim;
    private bool dashing;
    public float dashSpeed;
    private float maxspeed;
	// Use this for initialization
	void Start () {
        base.Start();
        anim = GetComponent<Animator>();
        maxspeed = dashSpeed + speed;
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
        dashing = true;
        anim.SetBool("Dashing", true);
        speed = maxspeed;
    }

    public void setDashing()
    {
        dashing = false;
        anim.SetBool("Dashing", false);
        speed -= dashSpeed;
    }
}
