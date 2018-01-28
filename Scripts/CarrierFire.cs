using UnityEngine;

using System.Collections;



public class CarrierFire : MonoBehaviour {

	
  
public Transform m_FireTransform; 
public Transform m_FireTransform2;
public Transform m_FireTransform3;
public Transform m_FireTransform4; 
public Rigidbody m_Shell;
public float value = 12f;

private int counter = 0;


void Update() {

   ++counter;   
   if(counter == 25){
         Fire (); 
         counter = 0; 
   }
}

public void Fire ()
{
     Rigidbody shellInstance = Instantiate (m_Shell, m_FireTransform.position, m_FireTransform.rotation) as Rigidbody;
     shellInstance.velocity = value * m_FireTransform.forward; 

     Rigidbody shellInstance2 = Instantiate (m_Shell, m_FireTransform2.position, m_FireTransform2.rotation) as Rigidbody;
     shellInstance2.velocity = value * m_FireTransform2.forward; 

     Rigidbody shellInstance3 = Instantiate (m_Shell, m_FireTransform3.position, m_FireTransform3.rotation) as Rigidbody;
     shellInstance3.velocity = value * m_FireTransform3.forward; 

     Rigidbody shellInstance4 = Instantiate (m_Shell, m_FireTransform4.position, m_FireTransform4.rotation) as Rigidbody;
     shellInstance4.velocity = value * m_FireTransform4.forward; 

}

}