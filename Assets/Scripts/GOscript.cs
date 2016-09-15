using UnityEngine;
using System.Collections;

public class GOscript : MonoBehaviour {

	public GUIText scored;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		scored.text = "Score: " + FoodCreator.score.ToString ();
		if (Input.GetKeyDown (KeyCode.Return)) 
		{
			Application.Quit();
		}
	}
}
