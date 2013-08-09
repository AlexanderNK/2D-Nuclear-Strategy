using UnityEngine;
using System.Collections;

public class Factory : MonoBehaviour
{
	public int men = 9;
	public const int ALC = 20;
	public GameObject alcoholic;
	private GameManager gm;
	OTSprite myGraphics;

	void Start ()
	{
		gm = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<GameManager> ();
		myGraphics = transform.GetComponentInChildren<OTSprite> ();
	}
	
	void Update ()
	{
		if (myGraphics.clicked && Input.GetMouseButtonDown (0) && gm.AlcoholAmount >= ALC && gm.men > 1) {
			CreateAlcoholics ();
		}
		gm.alcoholAmount += Time.deltaTime * men;
	}
	
	void CreateAlcoholics ()
	{
		GameObject newAlcoholic = Instantiate (alcoholic, gm.waypoints [gm.waypoints.Length - 1].position, Quaternion.identity) as GameObject;
		gm.alcoholAmount -= ALC;
		gm.men--;
	}
}
