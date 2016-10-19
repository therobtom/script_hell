using UnityEngine;
using System.Collections;

public class DBC : MonoBehaviour 
{
	void OnTriggerEnter(Collider other) {

		if (other.tag == "bounds") {
			return;
		}
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}