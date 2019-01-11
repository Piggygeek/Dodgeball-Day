using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Reset : MonoBehaviour {

	Vector3 originalPos;
	public int Lives = 3;
	public Text loseText;

	// Use this for initialization
	void Start () 
	{
		originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
		loseText.text = "";
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void FixedUpdate ()
	{
		if (Lives <= 0) 
		{
			gameObject.SetActive (false);
			loseText.text = "You lose! Try again?";
		}
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ( "Reset"))
		{
			transform.position = originalPos;
			Lives = Lives - 1;
		}
	}
}



