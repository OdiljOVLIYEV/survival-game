using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	private float speed = 2f;
	
	Animator anim;
	Rigidbody2D rb;
	
	public float hz;
	public bool attack= false;
    // Start is called before the first frame update
    void Start()
    {
	    rb=GetComponent<Rigidbody2D>();
	    anim=GetComponent<Animator>();
	    
    }

    // Update is called once per frame
    void Update()
	{
		
			
	    hz=Input.GetAxisRaw("Horizontal"); 
		//Debug.Log(hz);
		
		
		if(hz==0){
			if(attack==false){
			anim.Play("Idle");
			}
			if(attack==true){
				anim.Play("Attack Main Hand 2");
			}
		
		}
		
		if(hz>0){
			attack=false;
			anim.Play("Walk");
			gameObject.transform.localScale=new Vector3(0.1279526f,0.0860232f,1);
		}
		if(hz<0){
			attack=false;
		    gameObject.transform.localScale=new Vector3(-0.1279526f,0.0860232f,1);
			anim.Play("Walk");
		}
		
		if(Input.GetKeyUp(KeyCode.F)){
			attack=true;
			Invoke("delay",0.3f);
			
		}
		

		
		}
	
	void delay(){
		
		attack=false;
			
	}
	
    
	// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	private void FixedUpdate(){
	
		rb.velocity = new Vector2(hz*speed,rb.velocity.y);
	}
    
}
