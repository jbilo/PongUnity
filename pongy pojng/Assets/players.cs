  using UnityEngine;
using System.Collections;

public class players : MonoBehaviour {

	public int playerNumber;
	public float speed;

	// Use this for initialization
	void Start () {
		speed = 8;
	}
	
	// Update is called once per frame
	void Update () {
		if(playerNumber==1){
			//do player1 stuff here 
			Player1Update();

		}
		if(playerNumber==2){
			Player2Update();
		}
	}

	void Player1Update(){
	if(Input.GetKey(KeyCode.UpArrow)&&transform.position.y < 5){
			transform.position = transform.position + new Vector3(0f,1f,0f)*Time.deltaTime*speed;
	} 
		if(Input.GetKey(KeyCode.DownArrow)&&transform.position.y > -3.1){
			transform.position = transform.position + new Vector3(0f,-1f,0f)*Time.deltaTime*speed;
		} 
}
	void Player2Update(){
		if(Input.GetKey(KeyCode.W)&&transform.position.y < 5){
			transform.position = transform.position + new Vector3(0f,1f,0f)*Time.deltaTime*speed;
}
		if(Input.GetKey(KeyCode.S)&&transform.position.y > -3.1){
			transform.position = transform.position + new Vector3(0f,-1f,0f)*Time.deltaTime*speed;
		}
	}
}

