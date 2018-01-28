using UnityEngine;

using System.Collections;



public class AirMovement : MonoBehaviour {

	
	
  private Rigidbody m_Rigidbody;            
  private Vector3 movement;
  public static float speed = 0f;

void Start () {
	
	
	m_Rigidbody = GetComponent<Rigidbody> ();
}
	
	

void Update () {
	
	
   movement = transform.forward * speed * Time.deltaTime;
   m_Rigidbody.MovePosition(m_Rigidbody.position + movement);
}


}
