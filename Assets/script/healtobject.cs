using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healtobject : MonoBehaviour
{
	public float Healt=40f;
	public GameObject child;
	public GameObject textureone;
	public GameObject texturetwo;
	public BoxCollider2D bx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
	{
    	
		
        
	}
    
	public void damage(float amount){
		Healt-=amount;
		
		if(Healt<=0f){
			
			textureone.SetActive(false);
			texturetwo.SetActive(true);
			Instantiate(child,gameObject.transform.position,Quaternion.identity);
			
			Invoke("call",0.2f);
			
			//Destroy(gameObject,0.1f);
			Debug.Log("dead");
		}
	}
	
	void call(){
		
		bx.isTrigger=enabled;
		
	}
}
