using UnityEngine;
using System.Collections;

public class RT_Destroy_By_Time : MonoBehaviour
{
	public float lifetime;

	void Start ()
	{
		Destroy (gameObject, lifetime);
	}
}
