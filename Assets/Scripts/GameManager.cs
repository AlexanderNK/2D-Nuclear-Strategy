using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
	public bool checkDir;
	public Transform[] waypoints;
	private MoveAbstainer abstainer;
	public List<MoveAlcoholics> alcoholics;
	public float alcoholAmount = 100f;
	public float alcoBar;
       
	public int AlcoholAmount {
		get {
			return Mathf.FloorToInt (alcoholAmount);
		}
	}

	void Start ()
	{
		alcoBar = Screen.width / 2;
	}
	
	//void Update(){
	//             addalcoBar(1);
	//}
	
	void OnGUI ()
	{
		GUI.Box (new Rect (10, 10, alcoBar, 20), AlcoholAmount.ToString ());
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
