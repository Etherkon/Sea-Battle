using UnityEngine;

using System.Collections;



public class Touch : MonoBehaviour {

	
   
public float speed = 1f;   

public Rigidbody m_Rigidbody; 
private bool fires = false;
private bool rotates = false;
private bool move = false;
private bool turnL = false; 
private bool turnR = false;
private bool turnU = false;
private bool turnD = false;


void Update() {
	if(Input.touchCount > 0  && move == false) { 
		AirMovement.speed = 4f;
		move = true; 
	}

	if(turnL == true && move == true) {
		Quaternion turnSides = Quaternion.Euler (0f, -speed, 0f);
		m_Rigidbody.MoveRotation (m_Rigidbody.rotation * turnSides);
	}
	if(turnR == true && move == true) 
	{
		Quaternion turnSides = Quaternion.Euler (0f, speed, 0f);
		m_Rigidbody.MoveRotation (m_Rigidbody.rotation * turnSides);
	}
	if(turnU == true && move == true) 
	{
		AirMovement.speed = 20f;
		Quaternion turnUp = Quaternion.Euler (speed, 0f, 0f);
		m_Rigidbody.MoveRotation (m_Rigidbody.rotation * turnUp);
	}
	if(turnD == true && move == true) 
	{
		Quaternion turnUp = Quaternion.Euler (-speed, 0f, 0f);
		m_Rigidbody.MoveRotation (m_Rigidbody.rotation * turnUp);
	}
	if(fires == true && move == true) { AirFire.fired = true; }
	if(rotates == true && move == true) {
		Quaternion rot = Quaternion.Euler (0f, 0f, speed);
		m_Rigidbody.MoveRotation (m_Rigidbody.rotation * rot);
 	}
}

public void turnLeft() {
	turnL = true;
}
public void endTurnLeft() {
	turnL = false;
}

public void turnRight() {
	turnR = true;
}
public void endTurnRight() {
	turnR = false;
}

public void turnUp() {
	turnU = true;
}
public void endTurnUp() {
	turnU = false;
}

public void turnDown() {
	turnD = true;
}
public void endTurnDown() {
	turnD = false;
}

public void rotate() {
	rotates = true;
}
public void endRotate() {
	rotates = false;
}

public void fire() {
	fires = true;
}
public void endFire() {
	fires = false;
}


}