using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour {

	public Transform target;
	public Vector3 offset = new Vector3(1f, 7.5f, 1f);
	public float smoothSpeed = 0.25f;

	
	// Update is called once per frame
	public void FixedUpdate () {
		Vector3 desiredPosition = target.position + offset;
		Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
		transform.position = smoothPosition;
		transform.LookAt(target);
	}
}
