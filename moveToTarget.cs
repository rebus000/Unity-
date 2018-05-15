using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class moveToTarget : MonoBehaviour {
	Rigidbody cilinder;
	NavMeshAgent nav;
	public Transform target;

	void Start () {
		nav = GetComponent<NavMeshAgent> ();
		cilinder = GetComponent<Rigidbody> ();

	}
	void Update () {
		nav.SetDestination (target.position);


	}
	void OnCollisionEnter (Collision arg){
		if (arg.gameObject.tag=="Player") {
			Destroy (arg.gameObject);
		}

	}
}
