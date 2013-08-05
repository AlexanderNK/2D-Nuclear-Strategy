using UnityEngine;
using System.Collections;

public class MoveAlcoholics : MonoBehaviour {

	public float speed = 10f;
	public float rotationSpeed = 2f;
	private GameManager gm;
	private int cur = 24;

	void Start ()
	{
		gm = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<GameManager> ();
            
	}
       
	void Update ()	{
				
		if (cur >= 0) {
			Vector3 dest = gm.waypoints [cur].position;
			Vector3 dir = dest - transform.position;
			Vector3 nextStep = dir.normalized * speed * Time.deltaTime;
			if (dir.sqrMagnitude < nextStep.sqrMagnitude){
				cur--;
			} else {
				transform.position += nextStep;
			}
		}
	}
}
