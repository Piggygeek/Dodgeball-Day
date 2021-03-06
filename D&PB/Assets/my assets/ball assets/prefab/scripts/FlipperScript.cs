using System.Collections;
using System.Collections.Generic;
using UnityEngine;


	public class FlipperScript : MonoBehaviour {

		public float restPosition = 0f;

		public float pressedPosition = 45f;

		public float hitStrenght = 100000f;

		public float flipperDamper = 150f;

		HingeJoint hindge;

		public string inputName;

		// Use this for initialization
		void Start ()
		{
			hindge = GetComponent<HingeJoint> ();
			hindge.useSpring = true;
		}

		// Update is called once per frame
		void Update ()
		{ 
			JointSpring spring = new JointSpring ();
			spring.spring = hitStrenght;
			spring.damper = flipperDamper;

			if (Input.GetAxis(inputName) == 1) {
				spring.targetPosition = pressedPosition;
			} 
			else 
			{
				spring.targetPosition = restPosition;
			}
			hindge.spring = spring;
			hindge.useLimits = true;
		}
	}


