using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    private GameObject target;

    private Rigidbody2D myrigidbody;

    public float speed;

	// Use this for initialization
	void Start () {
        target = GameObject.FindWithTag("Player");
        myrigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float playerY = target.transform.position.y;
        transform.position = new Vector2(transform.position.x, playerY);
        myrigidbody.velocity = new Vector2(speed, 0);
	}
}
