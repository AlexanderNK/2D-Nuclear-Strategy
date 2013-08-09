using UnityEngine;
using System.Collections;
 
public class MoveAbstainer : MonoBehaviour
{
       
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
		if(cur == gm.waypoints.Length-1){
			Application.LoadLevel("Game over");
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
	
	
}
