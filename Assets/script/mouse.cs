using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
	
	public float speed  = 5f;
	private Vector3 target;
	
	public bool move;
    // Start is called before the first frame update
    void Start()
    {
	    target= transform.position;
	    
    }

    // Update is called once per frame
    void Update()
    {
	    if(Input.GetMouseButtonDown(0))
	    {
	    	
	    	target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	    	target.y=transform.position.y;
	    	target.z = transform.position.z;
	    	if(move ==false){
	    		move=true;
	    	}
	    } 
	     if(move ==true){
	    	
	    	transform.position=Vector3.MoveTowards(transform.position,target,speed*Time.deltaTime);    
	    }
	    }
	    
}
