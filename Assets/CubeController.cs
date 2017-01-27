using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    public GameObject anchor;
    public GameObject actor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        actor.transform.RotateAround(anchor.transform.position, Vector3.up, 200 * Time.deltaTime);
	}
}
