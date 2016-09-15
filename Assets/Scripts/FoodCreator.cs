using System;
using UnityEngine;
using System.Collections;

public class FoodCreator : MonoBehaviour {
	
	public GameObject foodPrefab, boosterPrefab;
	float zBoundMin, zBoundMax;
	public static uint score = 0;
	public GUIText countText;
	public static float myTimer = 59.0f;
	public float boosTimer = 10.0f;



	public void FoodGenerator()
	{
		//find  bounds of plane
		Bounds planeBounds = GameObject.Find ("Plane").collider.bounds;
		//zBoundMin = planeBounds.min.z;
		//zBoundMax = planeBounds.max.z;
		zBoundMin = -10f;
		zBoundMax = 10f;
		//object will appear at random place
		System.Random rnd = new System.Random ();
		
		int firstCoord = rnd.Next ((int)zBoundMin, (int)zBoundMax);
		int secondCoord = rnd.Next ((int)zBoundMin, (int)zBoundMax);
		Instantiate (foodPrefab, new Vector3(firstCoord, 5, secondCoord), transform.rotation);
	}
	// Use this for initialization
	void Start () {
		FoodGenerator ();
	}

	void Update()
	{
		myTimer -= Time.deltaTime;
		boosTimer -= Time.deltaTime;
		countText.text = "Score: " + score.ToString () + "   Time: " + myTimer.ToString("0");

		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Application.LoadLevel("exitscene");
		}

		if (myTimer <= 0) 
		{
			Application.LoadLevel("GameOverScene");
		}

		if ((int)boosTimer == 0)
		{
			//find  bounds of plane
			Bounds planeBounds = GameObject.Find ("Plane").collider.bounds;
			//zBoundMin = planeBounds.min.z;
			//zBoundMax = planeBounds.max.z;
			zBoundMin = -10f;
			zBoundMax = 10f;
			//object will appear at random place
			System.Random rnd = new System.Random ();

			int firstCoord = rnd.Next ((int)zBoundMin, (int)zBoundMax);
			int secondCoord = rnd.Next ((int)zBoundMin, (int)zBoundMax);
			Instantiate (boosterPrefab, new Vector3(firstCoord, 5, secondCoord), transform.rotation);
			boosTimer = 10.0f;
		}


	}

}
