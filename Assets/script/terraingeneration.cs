using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terraingeneration : MonoBehaviour
{
	[SerializeField] int eniga;
	[SerializeField] GameObject grass;
	
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
		
		for(int x=0; x<eniga;x++){
			
			Instantiate(grass,new Vector2(x,0),Quaternion.identity);
		}
	}
}
