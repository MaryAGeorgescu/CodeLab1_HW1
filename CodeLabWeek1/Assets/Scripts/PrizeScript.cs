using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		print("Heya"); //just print it in the console 
		if (other.tag.Contains("Player"))
		{
			other.gameObject.GetComponent<PlayerController>().score++; // get the player controller and add 1 to it's score; the collider that hit the prize
		}
		Destroy(gameObject);//destroy the game object I am attached to
	}
}
