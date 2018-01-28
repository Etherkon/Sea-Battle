using UnityEngine;


using UnityEngine.UI;

using System.Collections;



public class Manager : MonoBehaviour {

	

public GameObject scene1;
public GameObject scene1u;
public GameObject scene2u;
public Transform player;
public Transform ucarrier;
public Transform battleship;
public Text debug;

private float dist;
private float dist2;
private bool GilesMet;
private bool LisetteMet;


private int timer;

void Start () {
	
	
	timer = 0;
	GilesMet = false;
	LisetteMet = false;
	scene1.SetActive(false);
}
	
	


void Update () {
	
	
	++timer;
	dist = Vector3.Distance(player.position, ucarrier.position);
	dist2 = Vector3.Distance(player.position, battleship.position);

	if(timer == 170) { 
		scene1.SetActive(true); 
		AnimationV.start = true;
	}
	
	 debug.text = dist2.ToString();

         if(dist < 250f && GilesMet == false) {
		scene1u.SetActive(true); 
		GilesMet = true;		
	}

	if(dist2 < 200f && LisetteMet == false) { 
		scene2u.SetActive(true); 
		LisetteMet = true;
	}
}




}
