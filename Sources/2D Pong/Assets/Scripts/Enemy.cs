using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour 
{
	int speed = 25;

	public GameObject Ball;

	void Update () 
	{
		float vBound = Camera.main.orthographicSize - transform.localScale.y/2;

		if (Ball.transform.position.x > 0)
		{
			if (Ball.transform.position.y > transform.position.y + transform.localScale.y/2
			 	&& transform.position.y < vBound)
			{
				transform.Translate (Vector2.up * speed * Time.deltaTime);
			}
			else if (Ball.transform.position.y < transform.position.y - transform.localScale.y/2
				&& transform.position.y > -vBound)
			{
				transform.Translate (Vector2.down * speed * Time.deltaTime);
			}
		}
	}
}