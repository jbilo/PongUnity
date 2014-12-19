using UnityEngine;
using System.Collections;

public class spherebehavior : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		speed = 10f;
		Debug.Log("init");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x, transform.position.y, 1f);
		rigidbody.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);

	}

	void OnCollisionEnter(Collision other){
		Debug.Log("COLLISION HAPPENED");
		transform.forward = Vector3.Reflect(transform.forward, other.contacts[0].normal);
		float distance = Vector3.Distance(transform.position, other.gameObject.transform.position);
		distance *= distance * distance;

		float bally = transform.position.y;
		Vector3 towards = Vector3.up;
		if (bally < other.gameObject.transform.position.y){
			//below
			towards = -Vector3.up;
		}
		else{
			//above
			towards = Vector3.up;
		}
		//transform.RotateAround(transform.position, Vector3.forward, distance * 20f);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(towards), distance * 10f);
	}
}
