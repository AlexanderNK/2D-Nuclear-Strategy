﻿using UnityEngine;
using System.Collections;
 
public class MoveAbstainer : MonoBehaviour
{
       
	public float speed = 10f;
	public float rotationSpeed = 2f;
	private GameManager gm;
	private int cur = 0;

	void Start ()
	{
		gm = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<GameManager> ();
            
	}
       
	void Update ()
	{
		//transform.position += new Vector3 (30f * Time.deltaTime, 0, 0);
		/* if(Input.GetKey("w")){
                        transform.position += new Vector3(0, 1f, 0);
                }
                if(Input.GetKey("s")){
                        transform.position -= new Vector3(0, 1f, 0);
                        
                }              
                if(Input.GetKey("a")){
                	transform.position -= new Vector3(60f*Time.deltaTime, 0, 0);
				}
				if(Input.GetKey("d")){
                	transform.position += new Vector3(60f*Time.deltaTime, 0, 0);
				}
				*/
				
		if (cur < gm.waypoints.Length) {
			Vector3 dest = gm.waypoints [cur].position;
			Vector3 dir = dest - transform.position;
			Vector3 nextStep = dir.normalized * speed * Time.deltaTime;
			if (dir.sqrMagnitude < nextStep.sqrMagnitude){
				cur++;
			} else {
				transform.position += nextStep;
			}
		}
	}
}