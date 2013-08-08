using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
	public bool checkDir;
	public Transform[] waypoints;
	private MoveAbstainer abstainer;
	public List<MoveAlcoholics> alcoholics;
	
	public MoveAbstainer Abstainer {
		get {
			if (abstainer == null) {
				abstainer = GameObject.FindGameObjectWithTag("Abstainer").GetComponent<MoveAbstainer> ();
			}
			return abstainer;
		}
	}
}
