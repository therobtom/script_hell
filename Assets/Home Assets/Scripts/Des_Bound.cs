using UnityEngine;
using System.Collections;

public class Des_Bound : MonoBehaviour 
{
	void OnTriggerExit(Collider other) {
		Destroy (other.gameObject);
	}
}
