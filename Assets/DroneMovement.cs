using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMovement : MonoBehaviour
{
	// object the drone will follow
	public Transform playerBody;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Vector3.Distance(transform.position, playerBody.transform.position) > 20f) {
			transform.localPosition = Vector3.MoveTowards(transform.position, playerBody.transform.position, .5f);
		}
	}
}
