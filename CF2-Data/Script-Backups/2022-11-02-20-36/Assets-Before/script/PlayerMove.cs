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
		//if(hz<=1&&hz>=-1)
		
		if(hz==0){
		
			
			if(attack==false){
				
				//anim.SetBool("upattack",false);
				anim.SetBool("attack",false);
				anim.Play("Idle");
				
			}
			if(attack==true){
				
				anim.SetBool("upattack",false);
				anim.SetBool("attack",true);
				
			}
		
			
		}else{
			
			
		}
		
		if(hz==1||hz==-1){
			
			attack=false;
			
			
		}
		if(hz>0){
			
			if(attack==false){
				speed=2f;
				
			anim.Play("Walk");
				gameObject.transform.localScale=new Vector3(0.1109789f,0.07725209f,1);
			}
			if(attack==true){
				speed=0f;
				anim.SetBool("attack",true);
				
				//anim.Play("Attack Main Hand 2");
			}
			
		}
		if(hz<0){
			if(attack==false){
				speed=2f;
				
		    gameObject.transform.localScale=new Vector3(-0.1109789f,0.07725209f,1);
				anim.Play("Walk");
			}
			if(attack==true){
				speed=0f;
				anim.SetBool("attack",true);
				
				//anim.Play("Attack Main Hand 2");
			}
		}
		
		if(Input.GetKeyUp(KeyCode.Mouse0)){
			
			anim.SetBool("upattack",false);
			attack=true;
			Invoke("delay",0.3f);
			
		}
		
		if(Input.GetKey(KeyCode.W)&&Input.GetKey(KeyCode.Mouse0)){
			attack=true;
			
			Debug.Log ("SALOM");
			//anim.SetBool("attack",true);
			anim.SetBool("attack",false);
			anim.SetBool("upattack",true);
		
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
