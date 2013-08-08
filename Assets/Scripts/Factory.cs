using UnityEngine;
using System.Collections;

public class Factory : MonoBehaviour {
	
	public const int ALCO = 20;
	public GameObject alcoholic;
	private GameManager gm;
	
	void Start () {
		gm = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<GameManager> ();
	}
	
	
	void Update () {
		if (Input.GetMouseButtonDown(0)&& gm.alco>ALCO){
			CreateAlcoholics ();
		}
		
	}
	
	void CreateAlcoholics (){
		GameObject newAlcoholic = Instantiate (alcoholic, gm.waypoints[gm.waypoints.Length-1].position,Quaternion.identity) as GameObject;
		gm.alco-=ALCO;
	}
}
