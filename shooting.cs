using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {
	Rigidbody rb;
	float a;
	float b;
	float c;
	Transform tr;
	public Rigidbody obj;
	Rigidbody clone;
	float mouseX;
	public Transform target;
	//float mouseY;
	void Start () {
		rb = GetComponent<Rigidbody> ();
		tr = GetComponent<Transform> ();
	}
	

	void Update () {
		a = Input.GetAxis ("Vertical");
		b = Input.GetAxis ("Horizontal");
		c = Input.GetAxis ("Fire1");
		mouseX = Input.GetAxis("Mouse X");
		//mouseY = Input.GetAxis("Mouse Y");
		Vector3 f=new Vector3(0,0,a);
		rb.AddForce(tr.forward*a*100f);
		Vector3 rotation=new Vector3(0,mouseX,0);

		tr.Rotate (rotation*10f);
		if (c > 0) {
			clone=Instantiate (obj,target.position,target.rotation);
			clone.AddForce (tr.forward * 3000f);
		}
	}
}
