using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour {

	public Transform Target;
	public float range = 70f;
	public string PlayerTag = "Player";

	public Transform partToRotate;
	public float fireRate = 2f;
	private float fireCountdown;

	public Transform EnemyShoot;
	public GameObject EdodgeBallPref;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("UpdateTarget", 0f, 0.5f);
		range = 70f;
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
	
	// Update is called once per frame
	void Update () 
	{
		if (Target == null)
			return;

		Vector3 dir = Target.position - transform.position;
		Quaternion lookRotation = Quaternion.LookRotation (dir);
		Vector3 rotation = lookRotation.eulerAngles;
		partToRotate.rotation = Quaternion.Euler (0f, rotation.y, 0f);


		if (fireCountdown <= 0f) 
		{
			Shoot ();
			fireCountdown = 1f / fireRate;

		}
		fireCountdown -= Time.deltaTime;

	}

	void OnDrawGizmosSelected ()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawSphere (transform.position, range);
	}


	void Shoot ()

	{
		GameObject BulletGo = (GameObject) Instantiate(EdodgeBallPref, EnemyShoot.position, EnemyShoot.rotation);
		Edodge EdodgeBall = BulletGo.GetComponent<Edodge> ();


	}
}
