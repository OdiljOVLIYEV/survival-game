using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
	int width;
	GameObject dirt;
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    Generation(); 
    }
    
	void Generation(){
		
		for(int x=0; x<width; x++){
			
			
			Instantiate(dirt,new Vector2(x,0),Quaternion.identity);
		}
		
		
		
	}
}
