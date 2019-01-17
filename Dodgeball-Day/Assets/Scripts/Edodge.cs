using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edodge : MonoBehaviour {

	public float speed = 5f;
	public Rigidbody EdodgeBall;
	private float m_CurrentLaunchForce = 25f;
	public Transform EnemyShoot;



	// Use this for initialization
	void Start () 
	{

	}



	
	// Update is called once per frame
	void Update ()
	{
		EdodgeBall.velocity = m_CurrentLaunchForce * EnemyShoot.forward; ;
	}

}