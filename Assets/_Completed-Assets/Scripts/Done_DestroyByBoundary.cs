using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour 
{
	void OnTriggerEnter(Collider other) {

		if (other.tag == "bounds") {
			return;
		}
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}