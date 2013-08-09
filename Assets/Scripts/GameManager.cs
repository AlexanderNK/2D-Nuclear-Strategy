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
	public int men = 9;
       
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
		GUI.Box (new Rect (10, 10, alcoBar - 10, 20), "Alcohol "+ AlcoholAmount.ToString ());
		GUI.Box (new Rect (210, 10,alcoBar - 20, 20) ,"Time " +TimeT.ToString());
	}
	public int TimeT {
		get {
			int i = Mathf.FloorToInt (60-Time.time);
			if (i<=0){
				Application.LoadLevel("You win");
			}
			return i;
		}
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
