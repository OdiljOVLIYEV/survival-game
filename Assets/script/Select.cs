using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
	public GameObject icon;
	
	void OnMouseDown(){
		Debug.Log("tegdi");
		
		icon.SetActive(true);
	}
	
	
	
}
