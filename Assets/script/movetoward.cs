using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetoward : MonoBehaviour
{   
	public float speed = 1.0f;
	public Transform player;
	public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
	void Update()
    {
	    float step =  speed * Time.deltaTime; // calculate distance to move
	    transform.position = Vector3.MoveTowards(target.transform.position, player.transform.position, step);
    }
}
