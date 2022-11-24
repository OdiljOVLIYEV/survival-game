using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toshadd : MonoBehaviour
{
	
	public int coin=0;
	
	// Awake is called when the script instance is being loaded.
	
    // Start is called before the first frame update
    void Start()
    {
	    // Invoke("call",0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	// Sent when an incoming collider makes contact with this object's collider (2D physics only).
	protected void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag=="tosh"){
			
			coin+=1;
			
			
			Destroy(col.gameObject,0.1f);
		
	}
		
		
		
	}
	
	// Sent when another object enters a trigger collider attached to this object (2D physics only).
	
		
	
	// Sent when a collider on another object stops touching this object's collider (2D physics only).
	
	
	// Sent when an incoming collider makes contact with this object's collider (2D physics only).
	// Sent when another object enters a trigger collider attached to this object (2D physics only).
	// Sent when another object enters a trigger collider attached to this object (2D physics only).
	
	public void call(){
		
		
		//bx.enabled=true;
	}
}
