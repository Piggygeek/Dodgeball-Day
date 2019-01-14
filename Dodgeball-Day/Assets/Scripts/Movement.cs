using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour 
{
	private Rigidbody m_Rigidbody;
	private float m_MovementInputValueFB;
	private float m_MovementInputValueLR;
	private string m_MovementAxisNameFB;
	private string m_MovementAxisNameLR;
	public float m_Speed = 12f; 

	private void Awake ()
	{
		m_Rigidbody = GetComponent<Rigidbody> ();
	}
	// Use this for initialization
	void Start () 
	{
		m_MovementInputValueFB = 0f;
		m_MovementInputValueLR = 0f;
		m_MovementAxisNameFB = "Vertical";
		m_MovementAxisNameLR = "Horizontal";
	}
	
	// Update is called once per frame
	void Update () 
	{
		m_MovementInputValueFB = Input.GetAxis (m_MovementAxisNameFB);
		m_MovementInputValueLR = Input.GetAxis (m_MovementAxisNameLR);
	}
	private void FixedUpdate ()
	{
		// Adjust the rigidbodies position and orientation in FixedUpdate.
		MoveFB ();
		MoveLR ();
	}
	private void MoveFB ()
	{
		// Create a vector in the direction the tank is facing with a magnitude based on the input, speed and the time between frames.
		Vector3 movementFB = transform.forward * m_MovementInputValueFB * m_Speed * Time.deltaTime;

		// Apply this movement to the rigidbody's position.
		m_Rigidbody.MovePosition(m_Rigidbody.position + movementFB);

	}
	private void MoveLR ()
	{
		Vector3 movementLR = transform.right * m_MovementInputValueLR * m_Speed * Time.deltaTime;

		m_Rigidbody.MovePosition (m_Rigidbody.position + movementLR);
	}
}
