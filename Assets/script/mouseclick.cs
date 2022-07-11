using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseclick : MonoBehaviour
{
	public Vector3 targetposition;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    if(Input.GetKeyDown(KeyCode.Mouse0)){
	    	
	    	targetposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	    }
	    
	    transform.position = Vector3.MoveTowards(transform.position,targetposition,Time.deltaTime*5);
    }
}
