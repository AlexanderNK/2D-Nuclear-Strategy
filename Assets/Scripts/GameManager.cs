using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	
	public Transform[] waypoints;
	private MoveAbstainer abstainer;
	
	public MoveAbstainer Abstainer {
		get {
			if (abstainer == null) {
				abstainer = GameObject.FindGameObjectWithTag("Abstainer").GetComponent<MoveAbstainer> ();
			}
			return abstainer;
		}
	}
}
