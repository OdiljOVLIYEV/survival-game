using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upexit : MonoBehaviour
{
    // Start is called before the first frame update
	// OnTriggerEnter is called when the Collider other enters the trigger.
	// Sent each frame where another object is within a trigger collider attached to this object (2D physics only).
	// Sent each frame where another object is within a trigger collider attached to this object (2D physics only).
	protected void OnTriggerStay2D(Collider2D other)
	{
		
		if(other.gameObject.tag=="weapon"/*&&Input.GetKeyUp(KeyCode.W)*/){
			
			Debug.Log("bor");
			
			if(Input.GetKeyUp(KeyCode.W)){
				
				Debug.Log("TEPAD2");
			}
			
		}else{
			
			
			
			
			Debug.Log("obyekt yo'q");
			
		}
	}
}
