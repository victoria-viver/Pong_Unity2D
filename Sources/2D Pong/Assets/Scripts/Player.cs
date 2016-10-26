using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	int speed = 25;
	
	void Update () 
	{
		float vBound = Camera.main.orthographicSize - transform.localScale.y/2;

		if (Input.GetKey (KeyCode.UpArrow) 
			&& transform.position.y < vBound)
		{
			transform.Translate (Vector2.up * speed * Time.deltaTime);
		}
		else if (Input.GetKey (KeyCode.DownArrow) 
				&& transform.position.y > -vBound)
		{
			transform.Translate (Vector2.down * speed * Time.deltaTime);
		}
	}
}