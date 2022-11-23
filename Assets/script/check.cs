using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
	public BoxCollider2D BX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	// Sent each frame where another object is within a trigger collider attached to this object (2D physics only).
	 void OnTriggerStay2D(Collider2D other)
	{
		Debug.Log(other.gameObject.tag);
		if(other.gameObject.tag=="weapon"&&Input.GetButtonUp("Jump")){
			
			//if(Input.GetButtonUp("Jump")){
				
			BX.enabled=true;
			
			//}
		}
	}
	
	
	// Sent when another object leaves a trigger collider attached to this object (2D physics only).
	 void OnTriggerExit2D(Collider2D other)
	{
		if(other.gameObject.tag=="weapon"){
			
			BX.enabled=false;
		}
		
		
	}
}
