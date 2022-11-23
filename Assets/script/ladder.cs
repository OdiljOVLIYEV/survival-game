using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladder : MonoBehaviour
{
	public Rigidbody2D rb;
	private float speed = 2f;
	public float yz;
	public bool tegdi;
    // Start is called before the first frame update
    void Start()
    {
	    tegdi=false;
    }

    // Update is called once per frame
    void Update()
	{   
		if(tegdi==true){
			
		
			
			
		 yz=ControlFreak2.CF2Input.GetAxisRaw("Vertical");
		
		}
		
	    
    }
	// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	protected void FixedUpdate()
	{
		if(tegdi==true){
			rb.velocity = new Vector2(rb.velocity.x,yz*speed);
		}
	}
	// OnTriggerStay is called once per frame for every Collider other that is touching the trigger.
	
	protected void OnTriggerStay2D(Collider2D other)
	{
		if(other.gameObject.tag=="ladder"){
			tegdi=true;
			rb.gravityScale=0f;
			Debug.Log("narvon");
			
		}
	}
	// Sent when another object leaves a trigger collider attached to this object (2D physics only).
	protected void OnTriggerExit2D(Collider2D other)
	{
		if(other.gameObject.tag=="ladder"){
			tegdi=false;
			rb.gravityScale=4f;
		}
	}	
	
}
