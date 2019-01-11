using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_movement : MonoBehaviour 
{
	float horizontalSpeed = 2.0f;

	void Update()
	{
		// Get the mouse delta. This is not in the range -1...1
		float h = horizontalSpeed * Input.GetAxis("Mouse X");

		transform.Rotate(0, h, 0);
	}
}