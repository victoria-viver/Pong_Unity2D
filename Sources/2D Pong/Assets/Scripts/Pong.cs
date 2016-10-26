using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pong : MonoBehaviour 
{
	int playerScore = 0;
	int enemyScore  = 0;

	float hBound = 0;

	public GameObject 	Ball;
	public GameObject 	Player;
	public GameObject 	Enemy;
	public GameObject 	TopBorder;
	public GameObject 	BottomBorder;

	public Text 		ScoreText;

	void Start () 
	{
		float vBound = Camera.main.orthographicSize;
			  hBound = Camera.main.orthographicSize * Screen.width / Screen.height;

		Player.transform.position = new Vector2 ((hBound - Player.transform.localScale.x - 1) * -1, 0);
		Enemy.transform.position  = new Vector2 (hBound - Enemy.transform.localScale.x - 1, 0);

		TopBorder.transform.localScale = BottomBorder.transform.localScale = new Vector2(hBound * 2, 1);

		TopBorder.transform.position 	 = new Vector2 (0, (vBound - TopBorder.transform.localScale.y) * -1);
		BottomBorder.transform.position  = new Vector2 (0, vBound - BottomBorder.transform.localScale.y);

		UpdateScore ();
	}
	   
	void Update ()                                                                                                                                             
	{
		if (Ball.transform.position.x > hBound || Ball.transform.position.x < -hBound)
		{
			Ball.GetComponent<Ball>().Reset();

			if (Ball.transform.position.x > hBound) 
				{ playerScore++; }
			else
				{ enemyScore++; }

			UpdateScore ();
		}
	}

	void UpdateScore () 
	{
		ScoreText.text = playerScore.ToString () + ":" + enemyScore.ToString ();
	}
}   