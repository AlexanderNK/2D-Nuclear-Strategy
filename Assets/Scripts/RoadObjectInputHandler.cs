using UnityEngine;
using System.Collections;

public class RoadObjectInputHandler : MonoBehaviour {

	
	
	void Update () {
		OTSprite mySprite= GetComponentInChildren<OTSprite> ();
		if (mySprite.clicked) {
			Debug.Log ("hello from  " + name);
		}
	}
	public void OnInput(OTObject owner)
{
    // check if we clicked the left mouse button
    if (Input.GetMouseButtonDown(0))
    {
    }
}
}
