using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayinventar : MonoBehaviour
{
	public static displayinventar inventar;
	
	public int healt; 
	public int daraxt;
	public int tosh;
	public int ovqat;
	public Text text;
	
    // Start is called before the first frame update
    void Start()
	{
		if(inventar == null){
			
			inventar=this;
		}
        
    }

    // Update is called once per frame
    void Update()
	{
    	
		toshadd add=FindObjectOfType<toshadd>();
		tosh=add.coin;
	   
		text.text=+tosh+"/20".ToString();
	
	    
    }
    
    
	
}
