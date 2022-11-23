using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downcheck : MonoBehaviour
{
	
	public  Vector2 pos;
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		pos=GameObject.FindGameObjectWithTag("Player").transform.position;
	}
	
	// Update is called every frame, if the MonoBehaviour is enabled.
	protected void Update()
	{
		
		
	}
    // Start is called before the first frame update
	// Sent each frame where another object is within a trigger collider attached to this object (2D physics only).
	protected void OnTriggerStay2D(Collider2D other)
	{
		
		if(other.gameObject.tag=="weapon"){
			
			if(Input.GetKey(KeyCode.W)){
	
				transform.Translate(new Vector2(pos.x, pos.y-1f*Time.deltaTime ));
				Debug.Log(pos.x+" "+pos.y);
				Animator anim=FindObjectOfType<Animator>();
				anim.SetBool("upexit",true);
				
				Debug.Log("tepaga");
			}
			
			}
	}
}
