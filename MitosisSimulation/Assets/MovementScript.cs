using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

	ScriptManager script;
	public GameObject manager;
	public bool beginMovement = false;
	public bool beginMovement2 = false;
	public bool cmove = false;
	public GameObject[] nodes;
	public GameObject[] nodes2;
	public GameObject destination;
	Vector3 moveVector, aimVector;
	int i = 0;
	public float speed, targetSpeed;
	public float rotateSpeed;
	Vector3 targetPosition;

	// Use this for initialization
	void Start () {
		targetPosition = transform.position;
		destination = nodes[0];
		script = manager.GetComponent<ScriptManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if ( beginMovement ) {
			moveVector = (destination.transform.position - targetPosition).normalized;
			targetPosition += moveVector * targetSpeed * Time.deltaTime;
			aimVector = destination.transform.position - transform.position;
			//transform.rotation = Quaternion.RotateTowards ( Quaternion.LookRotation ( aimVector, transform.up ), Quaternion.LookRotation ( transform.forward, transform.up ), Mathf.Rad2Deg * rotateSpeed * Time.deltaTime );
			if ( Vector3.Distance(targetPosition, destination.transform.position) < 0.05f) {
				i++;
				if ( i > nodes.Length ) {
					beginMovement = false;
					script.SendMessage("S1SwapSpindles");
					i = 0;
				} else {
					destination = nodes[i]; 
				}
			}	
			transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed ); 
			transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(aimVector), Time.deltaTime * rotateSpeed);
		}
		if ( beginMovement2 ) {
			moveVector = (destination.transform.position - targetPosition).normalized;
			targetPosition += moveVector * targetSpeed * Time.deltaTime;
			aimVector = destination.transform.position - transform.position;
			//transform.rotation = Quaternion.RotateTowards ( Quaternion.LookRotation ( aimVector, transform.up ), Quaternion.LookRotation ( transform.forward, transform.up ), Mathf.Rad2Deg * rotateSpeed * Time.deltaTime );
			if ( Vector3.Distance(targetPosition, destination.transform.position) < 0.06f) {
				i++;
				if ( i > nodes2.Length ) {
					beginMovement2 = false;
					script.SendMessage("S2SwapSpindles");
				} else {
					destination = nodes2[i]; 
				}
			}	
			transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed ); 
			transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(aimVector), Time.deltaTime * rotateSpeed);
		}
		if ( cmove ) {
			moveVector = (destination.transform.position - targetPosition).normalized;
			targetPosition += moveVector * targetSpeed * Time.deltaTime;
			aimVector = destination.transform.position - transform.position;
			//transform.rotation = Quaternion.RotateTowards ( Quaternion.LookRotation ( aimVector, transform.up ), Quaternion.LookRotation ( transform.forward, transform.up ), Mathf.Rad2Deg * rotateSpeed * Time.deltaTime );
			if ( Vector3.Distance(targetPosition, destination.transform.position) < 0.03f) {
				i++;
				if ( i > nodes2.Length ) {
					cmove = false;
				} else {
					destination = nodes[i]; 
				}
			}	
			transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed ); 
			transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(aimVector), Time.deltaTime * rotateSpeed);

		}
	}
}
