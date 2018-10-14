using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour {
    public float speed;
    public Rigidbody2D myrigidbody;

	// Use this for initialization
	void Start () {
        myrigidbody = GetComponent<Rigidbody2D>();
        myrigidbody.velocity = new Vector2(speed, 0);
	}
	
	// Update is called once per frame
	

    public virtual void Action()
    {
        
    }

    
}
