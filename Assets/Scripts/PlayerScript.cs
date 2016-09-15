using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	public  static float speed = 7;
	float zBoundMin, zBoundMax;

	void Start()
	{
		Bounds planeBounds = GameObject.Find ("Plane").collider.bounds;
		//zBoundMin = planeBounds.min.z;
		//zBoundMax = planeBounds.max.z;
		zBoundMin = -10f;
		zBoundMax = 10f;
	}

	// Update is called once per frame
	void Update () 
	{
			float translation = Input.GetAxis ("Vertical") * Time.deltaTime * speed;
			float translationv = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
			//transform.position += new Vector3 (translationv, 0, translation);
			transform.position = new Vector3 (Mathf.Clamp (transform.position.x, zBoundMin, zBoundMax), transform.position.y,
	                                 Mathf.Clamp (transform.position.z, zBoundMin, zBoundMax));
			transform.position += new Vector3 (translationv, 0, translation);
			transform.forward = Vector3.Normalize (new Vector3 (translationv, 0f, translation));
	}

		void OnCollisionEnter(Collision theCollision)
		{
			if (theCollision.gameObject.name.Contains("Food")) 
			{
				FoodCreator.score++;
			}
		}
}
