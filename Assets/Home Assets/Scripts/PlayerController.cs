using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;
}

	public class PlayerController : MonoBehaviour
{
	public float speed;
	public float tilt;
	public Boundary boundary;

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;

	private float nextFire;

	void Update ()
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire) 
		{
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			//GetComponent<AudioSource>().Play ();
		}
	}

	void Start()
	{
		boundary.xMin = -1.5f;
		boundary.xMax =  1.5f;
		boundary.yMin = -0.5f;
		boundary.yMax =  2;
	
}

	void FixedUpdate ()
	{
	float moveHorizontal = Input.GetAxis ("Horizontal");
	float moveVertical = Input.GetAxis ("Vertical");

	bool canMove = true;

		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f);

		GetComponent<Rigidbody> ().velocity = movement * speed;


		float xVect = Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax);
		//GetComponent<Rigidbody> ().position.x = xVect;

		float yVect = Mathf.Clamp (GetComponent<Rigidbody>().position.y, boundary.yMin, boundary.yMax);

		GetComponent<Rigidbody> ().position = new Vector3 (xVect, yVect, 0.0f);
		//GetComponent<Rigidbody>().position = new Vector3(1,1,1);


	}
}