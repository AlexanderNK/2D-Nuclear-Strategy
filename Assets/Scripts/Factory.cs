using UnityEngine;
using System.Collections;

public class Factory : MonoBehaviour {

	
	void Start () {
	
	}
	
	
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			CreateAlcoholics ();
		}
		
	}
	
	void CreateAlcoholics (){
		// GameObject newAlcoholic = Instantiate (obstaclePrefab, new Vector3 (Random.Range (-3, 4), 2,  + 70), transform.rotation) as GameObject;
	}
}
