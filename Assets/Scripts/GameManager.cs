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
	public OTCircleSprite sun;
	public float dayLength;
       
	public int AlcoholAmount {
		get {
			return Mathf.FloorToInt (alcoholAmount);
		}
	}

	void Start ()
	{
		alcoBar = Screen.width * 0.25f;
	}
	
	void Update ()
	{
		sun.fillFactor = 1 - Time.time / dayLength;
		if (Time.time > dayLength) {
			Application.LoadLevel ("You win");
		}
	}
	
	void OnGUI ()
	{
		GUI.Box (new Rect (10, 10, alcoBar - 10, 20), "Alcohol " + AlcoholAmount.ToString ());
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
