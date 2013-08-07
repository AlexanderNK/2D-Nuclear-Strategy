using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
	public bool checkDir;
	public Transform[] waypoints;
	private MoveAbstainer abstainer;
	public List<MoveAlcoholics> alcoholics;
	public int alco = 100;
	public float alcoBar;
       
	void Start ()
	{
		alcoBar = Screen.width / 2;
	}
	
	//void Update(){
	//             addalcoBar(1);
	//}
	
	void OnGUI ()
	{
		GUI.Box (new Rect (10, 10, alcoBar, 20), alco.ToString ());
	}

	public MoveAbstainer Abstainer {
		get {
			if (abstainer == null) {
				abstainer = GameObject.FindGameObjectWithTag ("Abstainer").GetComponent<MoveAbstainer> ();
			}
			return abstainer;
		}
	}
}
