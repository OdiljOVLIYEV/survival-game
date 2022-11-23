using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	private float speed = 2f;
	public float jumpHeight;
	Animator anim;
	Rigidbody2D rb;

	
	[HideInInspector]
	public float hz;
	[HideInInspector]
	public float yz;
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
		
		
		
			
		hz=ControlFreak2.CF2Input.GetAxisRaw("Horizontal");
		yz=ControlFreak2.CF2Input.GetAxisRaw("Vertical");
		//Debug.Log(yz);
		
		
		if(hz==0){
		
			
			
			if(attack==false){
				anim.SetBool("DownAttack",false);
				anim.SetBool("upattack",false);
				anim.SetBool("attack",false);
				//anim.SetBool("walk",false);
				anim.Play("Idle");
				
			}
			if(attack==true){
				//anim.SetBool("walk",false);
				anim.SetBool("upattack",false);
				anim.SetBool("attack",true);
				
			}
		
			
		}
		
		/*if(hz==1||hz==-1){
			
			attack=false;
			
			
		}*/
		if(hz>0){
			
			if(attack==false){
				speed=2f;
				//anim.SetBool("walk",true);
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
				anim.Play("Walk");
				//anim.SetBool("walk",true);
		    gameObject.transform.localScale=new Vector3(-0.1109789f,0.07725209f,1);
				
			}
			if(attack==true){
				speed=0f;
				anim.SetBool("attack",true);
				
				//anim.Play("Attack Main Hand 2");
			}
		}
		
		if(ControlFreak2.CF2Input.GetKeyUp(KeyCode.F)){
			
			anim.SetBool("upattack",false);
			attack=true;
			Invoke("delay",0.3f);
			
		}
		
		if(yz>0&&ControlFreak2.CF2Input.GetKeyUp(KeyCode.F)){
			attack=true;
			
			Debug.Log ("SALOM");
			//anim.SetBool("attack",true);
			anim.SetBool("attack",false);
			anim.SetBool("upattack",true);
		
			Invoke("delay",0.3f);
			
		}
		
		if(yz<0&&ControlFreak2.CF2Input.GetKeyUp(KeyCode.F)){
			attack=true;
			
			
			//anim.SetBool("attack",true);
			anim.SetBool("attack",false);
			anim.SetBool("DownAttack",true);
		
			Invoke("delay",0.3f);
			
		}
		if(Input.GetKeyUp(KeyCode.Space)){
			
			
			rb.AddForce(Vector2.up * jumpHeight);
		}
		
		}
	
	void delay(){
		
		attack=false;
			
	}
	// Sent each frame where another object is within a trigger collider attached to this object (2D physics only).
	// Sent each frame where another object is within a trigger collider attached to this object (2D physics only).
	
	
	// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	private void FixedUpdate(){
	
		rb.velocity = new Vector2(hz*speed,rb.velocity.y);
		
	}
    
	
    
}
