using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLives : MonoBehaviour {
	public int Life = 2;


	// Use this for initialization
	void Start () 
	{


	}

	// Update is called once per frame
	void Update () 
	{

	}

	void FixedUpdate ()
	{
		if (Life <= 0) 
		{
			gameObject.SetActive (false);

		}
	}
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Ball")) {

			Life = Life - 1;
		}
	}
}