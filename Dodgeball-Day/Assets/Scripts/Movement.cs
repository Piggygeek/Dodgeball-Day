using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour 
{
	private string m_MovementAxisName;
	private Rigidbody m_Rigidbody;
	private float m_MovementInputValue;
	public float m_Speed = 12f;

	// Use this for initialization
	void Start () 
	{
		m_Rigidbody = GetComponent<Rigidbody> ();
		m_MovementAxisName = "Vertical";
		m_MovementInputValue = 0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		m_MovementInputValue = Input.GetAxis (m_MovementAxisName);
	}
	private void FixedUpdate ()
	{
		// Adjust the rigidbodies position and orientation in FixedUpdate.
		Move ();
	}
	private void Move ()
	{
		// Create a vector in the direction the tank is facing with a magnitude based on the input, speed and the time between frames.
		Vector3 movement = transform.forward * m_MovementInputValue * m_Speed * Time.deltaTime;

		// Apply this movement to the rigidbody's position.
		m_Rigidbody.MovePosition(m_Rigidbody.position + movement);
	}
}
