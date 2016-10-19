using UnityEngine;
using System.Collections;

public class RT_Mover : MonoBehaviour
{
	public float speed;

	void Start ()
	{
		GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}
}
