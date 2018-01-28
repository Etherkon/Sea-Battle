using UnityEngine;

using System.Collections;



public class Controls : MonoBehaviour {

	
   
public float speed = 1f;   

private Rigidbody m_Rigidbody; 
private bool fly;
private bool move;
private bool goes;

void Awake() {
         m_Rigidbody = GetComponent<Rigidbody> ();
	 fly = false;
	 move = false;
	 goes = false;
}

void Update() {

	float turnU = Input.GetAxis("Vertical") * -speed;
	float turnS = Input.GetAxis("Horizontal") * speed;
	float rotate = Input.GetAxis("Fire1") * speed;
	float rotate2 = Input.GetAxis("Fire2") * speed;
	float fire = Input.GetAxis("Jump");
	float go = Input.GetAxis("Submit");

	if(turnU != 0 && turnS == 0  && move == true) {
		if(!fly) { AirMovement.speed = 16f; fly = true; }
		Quaternion turnUp = Quaternion.Euler (turnU, 0f, 0f);
		m_Rigidbody.MoveRotation (m_Rigidbody.rotation * turnUp);
	}

	if(turnS != 0 && turnU == 0  && move == true) {		
		Quaternion turnSides = Quaternion.Euler (0f, turnS, 0f);
		m_Rigidbody.MoveRotation (m_Rigidbody.rotation * turnSides);
	}

	if(rotate != 0  && move == true) {
		Quaternion rot1 = Quaternion.Euler (0f, 0f, rotate);
		m_Rigidbody.MoveRotation (m_Rigidbody.rotation * rot1);
	}
	
	if(rotate2 != 0  && move == true) {
		Quaternion rot2 = Quaternion.Euler (0f, 0f, -rotate2);
		m_Rigidbody.MoveRotation (m_Rigidbody.rotation * rot2);
	}

	if(fire != 0){ AirFire.fired = true; }
	else { AirFire.fired = false; }

	if(go != 0) { move = true; 
		if(!goes) { AirMovement.speed = 3f; goes = true; } }

}


}