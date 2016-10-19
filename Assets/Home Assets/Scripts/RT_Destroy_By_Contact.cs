using UnityEngine;
using System.Collections;

public class RT_Destroy_By_Contact : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary")
		{
			return;
		}
		Instantiate(explosion, transform.position, transform.rotation);
		if (other.tag == "Player")
		{
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
			//gameController.GameOver ();
		}
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}