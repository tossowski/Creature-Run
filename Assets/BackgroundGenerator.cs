﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGenerator : MonoBehaviour {

    public GameObject[] backgrounds;

    private float[] backgroundWidths;

	// Use this for initialization
	void Start () {
        backgroundWidths = new float[backgrounds.Length];
		for (int i = 0; i < backgrounds.Length; i++)
        {
            backgroundWidths[i] = backgrounds[i].GetComponent<SpriteRenderer>().sprite.rect.width / 113.13f;
            Debug.Log(backgroundWidths[i]);
        }
        for (int i = 0; i < 10; i++)
        {
            Instantiate(backgrounds[0], Vector3.zero + i * new Vector3(backgroundWidths[0], 0, 0), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
