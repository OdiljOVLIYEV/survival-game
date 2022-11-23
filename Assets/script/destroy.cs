using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
	public float damage=10f;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	// Sent when an incoming collider makes contact with this object's collider (2D physics only).
	
	// Sent when another object enters a trigger collider attached to this object (2D physics only).
	protected void OnTriggerEnter2D(Collider2D other)
	{
		
		PlayerMove hujum=FindObjectOfType<PlayerMove>();
		
		
		if(other.gameObject.tag=="weapon"&&hujum.attack==true){
			
			
			healtobject target	= other.GetComponent<healtobject>();
			if(target!=null)
			target.damage(damage);
			if(target!=null){
					
				
				
			}
			
			//Destroy(other.gameObject ,0.1f);
		}
	}
	// Sent each frame where another object is within a trigger collider attached to this object (2D physics only).
	
	
	
}
