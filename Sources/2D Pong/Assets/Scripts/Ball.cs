using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour 
{
	int vBound = 0;
	int speed = 25;

	Rigidbody2D rb;

	void Awake ()
	{
		vBound = (int) Camera.main.orthographicSize;
		rb = GetComponent<Rigidbody2D>();

		Reset ();
	}

	void Update () 
	{
		Vector2 vel = rb.velocity;
		Vector2 vel2 = vel.normalized * speed;
		rb.velocity = Vector2.Lerp (vel, vel2, Time.deltaTime * speed);
	}

	public void Reset ()
	{
		transform.position = Vector2.zero;
		rb.velocity = Vector2.zero;

		Vector2 direction = new Vector2 (1, -vBound);
		
		if (Random.Range(0,1) < .5f) 
			{ direction.x *= -1; }

		rb.AddForce(direction * speed);
	}
}