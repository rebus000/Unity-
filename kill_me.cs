using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class kill_me : MonoBehaviour {

	Animator anim;
	NavMeshAgent nav;
	void Start () {
		anim = GetComponent<Animator> ();
		nav = GetComponent<NavMeshAgent> ();
	}
	void Update () {
	}
		void OnCollisionEnter (Collision arg){
			if (arg.gameObject.tag == "bullet") {
			anim.SetFloat ("dead", 0.5f);
			Destroy (arg.gameObject);
				//Destroy(gameObject);
			nav.enabled =  false;
			}
		}
}
