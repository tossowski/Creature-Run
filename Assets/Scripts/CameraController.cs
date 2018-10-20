using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject toFollow;

	// Use this for initialization
	void Start () {
        toFollow = GameObject.FindWithTag("Player");
        transform.position = new Vector3(toFollow.transform.position.x+2f, toFollow.transform.position.y+1, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(toFollow.transform.position.x+2f, toFollow.transform.position.y+1, transform.position.z);
    }
}
