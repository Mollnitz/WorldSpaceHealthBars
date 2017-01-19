using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    Transform transf;

	// Use this for initialization
	void Start () {

        transf = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        transf.position += new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
	}
}
