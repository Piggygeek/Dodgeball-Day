using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public float min=5f;
	public float max=10f;
	// Use this for initialization
	void Start () {

		min=transform.position.x;
		max=transform.position.x+15;

	}

	// Update is called once per frame
	void Update () {


		transform.position =new Vector3(Mathf.PingPong(Time.time*25,max-min)+min, transform.position.y, transform.position.z);

	}
}