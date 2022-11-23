using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terraingeneration : MonoBehaviour
{
	[SerializeField] int eniga,boyiga;
	[SerializeField] GameObject yer,grass;
	
    // Start is called before the first frame update
    void Start()
    {
        Generation();
    }

    // Update is called once per frame
  
    
	void Generation(){
		
		for(int x=0; x<eniga;x++){
			for(int y=0; y<boyiga;y++){
				
				Instantiate(yer,new Vector2(x,y),Quaternion.identity);
				
			}
			
			Instantiate(grass,new Vector2(x,boyiga+0.20f),Quaternion.identity);
			
		}
	}
}
