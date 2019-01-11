using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Lives : MonoBehaviour {

	public int Life = 3;
	public Text loseText;

	// Use this for initialization
	void Start () 
	{
		
		loseText.text = "";
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
			loseText.text = "You lose! Try again?";
		}
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ( "Ball"))
		{
			
			Life = Life - 1;
		}
	}
}

