using UnityEngine;
using System.Collections;

public class RT_RandomRotator : MonoBehaviour 
{
	public float tumble;
	
	void Start ()
	{
		GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
	}
}