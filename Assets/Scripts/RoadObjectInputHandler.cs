using UnityEngine;
using System.Collections;

public class RoadObjectInputHandler : MonoBehaviour {

	
	
	void Update () {
		OTSprite mySprite = GetComponentInChildren<OTSprite> ();
		if (mySprite.clicked) {
			Debug.Log ("hello from  " + name);
		}
	}
	public void OnInput(OTObject owner)
{
    
    if (Input.GetMouseButtonDown(0))
    {
			
    }
}
}
