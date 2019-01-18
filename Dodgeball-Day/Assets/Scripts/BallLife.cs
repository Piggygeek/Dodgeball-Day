using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLife : MonoBehaviour {

	public float m_MaxLifeTime = 2f;                    // The time in seconds before the shell is removed.
	public Rigidbody dodgeBall;

	// Use this for initialization
	void Start () 
	{
		// If it isn't destroyed by then, destroy the shell after it's lifetime.
		Destroy (dodgeBall, m_MaxLifeTime);
	}

	// Update is called once per frame
	void Update () 
	{
		Destroy (gameObject, m_MaxLifeTime);
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ( "Player"))
		{
			gameObject.SetActive (false);
		}

		if (other.gameObject.CompareTag ( "Enemy"))
		{
			gameObject.SetActive (false);
		}
	}
}
