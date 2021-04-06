using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldScript : MonoBehaviour
{

	public GameObject Shield;
	public GameObject Capsule;
	private bool isShield=false;
	private float scale=2.857143f;

	private float x=0.797f;
	private float y=0.34f;
	private float z=0.89f;

    // Start is called before the first frame update
    void Start()
    {
        Shield.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
        	isShield=!isShield;
        	Shield.SetActive(isShield);
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
        	scale+=0.1f;
        	Shield.transform.localScale =new Vector3(scale, scale, scale);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
        	scale-=0.1f;
        	Shield.transform.localScale =new Vector3(scale, scale, scale);
        }
        if(Input.GetKey("t")){
        	z-=0.05f;
        	Capsule.transform.position = new Vector3(x, y, z);
        }
        if(Input.GetKey("g")){
        	z+=0.05f;
        	Capsule.transform.position = new Vector3(x, y, z);
        }
        if(Input.GetKey("h")){
        	x-=0.05f;
        	Capsule.transform.position = new Vector3(x, y, z);
        }
        if(Input.GetKey("f")){
        	x+=0.05f;
        	Capsule.transform.position = new Vector3(x, y, z);
        }
        
    }
}
