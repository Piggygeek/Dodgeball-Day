using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edodge : MonoBehaviour {

	public float speed = 5f;
	public Rigidbody EdodgeBall;
	private float m_CurrentLaunchForce = 25f;
	public Transform EnemyShoot;
	public Transform Target;

	public float range = 70f;
	public string PlayerTag = "Player";

	public Transform partToRotate2;
	public float fireRate = 2f;
	private float fireCountdown;


	// Use this for initialization
	void Start () 
	{

	}



	
	// Update is called once per frame
	void Update ()
	{
		EdodgeBall.velocity = m_CurrentLaunchForce * EnemyShoot.forward; ;

		if (Target == null)
			return;

		Vector3 dir = Target.position - transform.position;
		Quaternion lookRotation = Quaternion.LookRotation (dir);
		Vector3 rotation = lookRotation.eulerAngles;
		partToRotate2.rotation = Quaternion.Euler (0f, rotation.y, 0f);

	}

	void UpdateTarget ()
	{
		GameObject[] player = GameObject.FindGameObjectsWithTag ("Player");
		float shortestDistance = Mathf.Infinity;
		GameObject nearestEnemy = null;
		foreach (GameObject Player in player) 
		{
			float distanceToEnemy = Vector3.Distance (transform.position, Player.transform.position);
			if (distanceToEnemy < shortestDistance) 
			{
				shortestDistance = distanceToEnemy;
				nearestEnemy = Player;
			}
		}
		if (nearestEnemy != null && shortestDistance <= range) {
			Target = nearestEnemy.transform;
		} 
		else 
		{
			Target = null;
		}
	}

}