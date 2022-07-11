using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousemove : MonoBehaviour
{
	public float speed = 1.0f;
	public Transform target;
	public bool tegdi;
	void Start () {
		
		
		
            }
		
	void Update(){
		
		if(tegdi==true){
		float step =  speed * Time.deltaTime; // calculate distance to move
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
		}
	
}
		
			
	}
		
		
		
	


