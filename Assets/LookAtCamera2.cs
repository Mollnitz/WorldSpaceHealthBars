using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Camera cam = Camera.main;
        transform.rotation = Quaternion.LookRotation(-cam.transform.forward, cam.transform.up);
	}
}
