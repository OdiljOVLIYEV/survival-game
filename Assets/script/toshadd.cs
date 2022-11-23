using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toshadd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	// Sent when an incoming collider makes contact with this object's collider (2D physics only).
	protected void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag=="Player"){
			
			displayinventar inventar=FindObjectOfType<displayinventar>();
			inventar.tosh=+4;
			Destroy(gameObject,0.1f);
			
		}
	}
	// Sent when an incoming collider makes contact with this object's collider (2D physics only).
	
}
