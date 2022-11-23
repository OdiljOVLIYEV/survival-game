using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tepaga : MonoBehaviour
{
	public BoxCollider2D BX;
	
    // Start is called before the first frame update
    void Start()
	{
		
        
    }

    // Update is called once per frame
	// Update is called every frame, if the MonoBehaviour is enabled.
	protected void Update()
	{
		/*if(Input.GetKeyUp(KeyCode.Space)){
			
			BX.enabled=true;
		}*/
	}
    
	
	
	
	
	// Sent each frame where a collider on another object is touching this object's collider (2D physics only).
	protected void OnCollisionStay2D(Collision2D col)
	{
		
		if(col.gameObject.tag=="weapon"){
			
			
			Animator anim=FindObjectOfType<Animator>();
			anim.SetBool("tepaga",true);
			PlayerMove value=FindObjectOfType<PlayerMove>();
			value.hz=0.1f;
			value.jumpHeight=440f;
			
			
		}
	}
    
	// Sent when a collider on another object stops touching this object's collider (2D physics only).
	protected void OnCollisionExit2D(Collision2D col)
	{
		if(col.gameObject.tag=="weapon"){
			
			Animator anim=FindObjectOfType<Animator>();
			anim.SetBool("tepaga",false);
			
			PlayerMove value=FindObjectOfType<PlayerMove>();
			value.hz=0.0f;
			value.jumpHeight=430f;
			//BX.enabled=false;
		}
		
	}
    
}
