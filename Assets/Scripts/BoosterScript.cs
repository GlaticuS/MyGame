using UnityEngine;
using System.Collections;

public class BoosterScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision theCollision)
	{
		if (theCollision.gameObject.name == "Snake") 
		{
			Destroy(gameObject);
			System.Random rnd = new System.Random();
			int choice = rnd.Next(1, 3);
			if(choice == 1)
			{
				PlayerScript.speed += 2;
			}
			else
			{
				FoodCreator.myTimer += 10;
			}
		}
	}
}
