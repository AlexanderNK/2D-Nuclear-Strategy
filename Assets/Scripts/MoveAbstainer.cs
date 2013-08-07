﻿using UnityEngine;
using UnityEngine;
using System.Collections;
 
public class MoveAbstainer : MonoBehaviour
{
       
<<<<<<< HEAD
<<<<<<< HEAD
	public float speed = 10f;
	private GameManager gm;
	private int cur = 0;
	public bool isMovingForward;
	/// <summary>
	/// How long is Abstainer moves back.
	/// </summary>
	public float backMovingTime;
	/// <summary>
	/// Last time when abstainer started moving back
	/// </summary>
	private float lastBackMoveTime;

	void Start ()
	{
		gm = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<GameManager> ();
		SetDirection (true);
	}
=======
=======
>>>>>>> 2d45d683b225968072c30d1be90ee785aade8615
        public float speed = 10f;
        public float rotationSpeed = 2f;
        private GameManager gm;
        public int cur = 0;
        private int i = 0;
 
        void Start ()
        {
                gm = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<GameManager> ();
                gm.checkDir = true;
           
        }
<<<<<<< HEAD
>>>>>>> 2d45d683b225968072c30d1be90ee785aade8615
=======
>>>>>>> 2d45d683b225968072c30d1be90ee785aade8615
       
        void Update ()
        {
                //transform.position += new Vector3 (30f * Time.deltaTime, 0, 0);
                /* if(Input.GetKey("w")){
                        transform.position += new Vector3(0, 1f, 0);
                }if ((gm.Abstainer.transform.position - gm.Alcoholics.transform.position).sqrMagnitude < 20) {
                        Destroy (Alcoholics);
                }
                if(Input.GetKey("s")){
                        transform.position -= new Vector3(0, 1f, 0);
                       
                }              
                if(Input.GetKey("a")){
<<<<<<< HEAD
<<<<<<< HEAD
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
			
			if (dir.sqrMagnitude < nextStep.sqrMagnitude) {
				if (isMovingForward) {
					cur++;
				} else {
					cur--;
				}
			} else {
				if(cur>0){
					transform.position += nextStep;
				}
			}
		}
		
		if (!isMovingForward) {
			if (lastBackMoveTime + backMovingTime < Time.time) {
				SetDirection (true);
			}
		}
	}
	
	/// <summary>
	/// Sets the direction.
	/// </summary>
	/// <param name='isForward'>
	/// Is forward direction.
	/// </param>
	public void SetDirection (bool isForward)
	{
		// If we really change direction
		if (isForward != isMovingForward) {
			// Fall back to previous waypoint
			if (isForward) {
				cur++;
			} else {
				cur--;
			}
			isMovingForward = isForward;
		}
		
		// Save time when we was send backward
		if (!isForward) {
			lastBackMoveTime = Time.time;
		}
	}
=======
=======
>>>>>>> 2d45d683b225968072c30d1be90ee785aade8615
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
                       
                       
                        if (dir.sqrMagnitude < nextStep.sqrMagnitude) {
                                if (gm.checkDir) {
                                        cur++;
                                } else {
                                        if (cur > 0) {
                                                cur--;
                                                if (i > 1) {
                                                        gm.checkDir = true;
                                                        i = 0;
                                                } else {
                                                        i++;
                                                }
                                        } else {
                                                gm.checkDir = true;
                                        }
                                }
                        } else {
                                transform.position += nextStep;
                               
                        }
                }
        }
<<<<<<< HEAD
>>>>>>> 2d45d683b225968072c30d1be90ee785aade8615
=======
>>>>>>> 2d45d683b225968072c30d1be90ee785aade8615
}
