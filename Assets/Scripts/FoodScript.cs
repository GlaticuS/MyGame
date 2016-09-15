using UnityEngine;
using System.Collections;

public class FoodScript : MonoBehaviour {

	public GameObject foodPrefab;
	float zBoundMin, zBoundMax;
	
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
		Instantiate (foodPrefab, new Vector3(firstCoord++, 5, secondCoord++), transform.rotation);
	}

	void OnCollisionEnter(Collision theCollision)
	{
		if (theCollision.gameObject.name == "Snake") 
		{
			Destroy(gameObject);
			FoodGenerator();
		}
	}
}
