using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour {
    public float speed;
    public Rigidbody2D myrigidbody;

    public GameObject ToSwitch;

	// Use this for initialization
	public virtual void Start () {
        myrigidbody = GetComponent<Rigidbody2D>();
        myrigidbody.velocity = new Vector2(speed, 0);
	}

    public void changeCharacter(GameObject c)
    {
        GameObject clone = Instantiate(c, transform.position, Quaternion.identity) as GameObject;
        GameObject.FindWithTag("MainCamera").GetComponent<CameraController>().toFollow = clone;
        //Destroy(gameObject);
    }

    public virtual void Action()
    {
        
    }

    
}
