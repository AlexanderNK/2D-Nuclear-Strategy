using UnityEngine;
using System.Collections;

public class MoveAlcoholics : MonoBehaviour
{
	public const float MIN_MEET_DISTANCE = 30f;
	public float speed = 10f;
	public float rotationSpeed = 2f;
	private GameManager gm;
	private int cur = 24;

	void Start ()
	{
		gm = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<GameManager> ();
		gm.alcoholics.Add (this);
	}
       
	void Update ()
	{
				
		if (cur >= 0) {
			Vector3 dest = gm.waypoints [cur].position;
			Vector3 dir = dest - transform.position;
			Vector3 nextStep = dir.normalized * speed * Time.deltaTime;
			if (dir.sqrMagnitude < nextStep.sqrMagnitude) {
				cur--;
			} else {
				transform.position += nextStep;
			}
		}
		
		CheckCollision();
		/*if (gm.Abstainer.transform.position.sqrMagnitude - nextStep.sqrMagnitude < 20) {
			Destroy (gameObject);
		} */
		
	}
	
	void CheckCollision ()
	{
		if (Vector3.Distance (gm.Abstainer.transform.position, transform.position) < MIN_MEET_DISTANCE) {
			gm.alcoholics.Remove (this);
			Destroy (gameObject);
		}
	}
}
