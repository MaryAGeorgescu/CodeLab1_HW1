using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	
	public KeyCode upKey;
	public KeyCode downKey;
	public KeyCode rightKey;
	public KeyCode leftKey;
	
	public float forceAmount = 10;
	
	private Rigidbody2D rb;

	public int score = 0;
	
	// Use this for initialization
	void Start ()
	{
		
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector2 newForce= new Vector2(0,0); //The force we will add to our player.
		
		if (Input.GetKey(upKey))//When someone presses "w"
		{
			newForce.y += forceAmount;// += means change it incrementally by this amount
		}

		if (Input.GetKey(downKey))
		{
			newForce.y -= forceAmount;
		}

		if (Input.GetKey(leftKey))
		{
			newForce.x -= forceAmount;
		}

		if (Input.GetKey(rightKey))
		{
			newForce.x += forceAmount;
		}
		
		rb.AddForce(newForce);
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		// if the collider that hit us has a tag wall
		if (other.gameObject.CompareTag("wall"))
		{
		
			Destroy(gameObject); //destroy the game object I am attached to
		}
		
	}
	
}
