using UnityEngine;

using System.Collections;



public class AirFire : MonoBehaviour {

	

public AudioSource m_ShootingAudio;  
public Transform m_FireTransform; 
public Transform m_FireTransform2;
public static bool fired = false; 
public Rigidbody m_Shell; 
public float value = 0f;
public Light alight;
public Light alight2;

private int counter = 0;

void Awake ()  
{
        alight.enabled = false; 
	alight2.enabled = false;   
}

void Update() {
     alight.enabled = false;
     alight2.enabled = false;

    if(fired == true){

        ++counter;   
        if(counter == 15){
            Fire (); 
            counter = 0; 
        }
     }
}

public void Fire ()
{
     m_ShootingAudio.Play ();  	
     alight.enabled = true;
     alight2.enabled = true;

     // First gun

     Rigidbody shellInstance = Instantiate (m_Shell, m_FireTransform.position, m_FireTransform.rotation) as Rigidbody;
     shellInstance.velocity = value * m_FireTransform.forward; 

        // Second Gun

     Rigidbody shellInstance2 = Instantiate (m_Shell, m_FireTransform2.position, m_FireTransform2.rotation) as Rigidbody;
     shellInstance2.velocity = value * m_FireTransform2.forward; 
}

}
