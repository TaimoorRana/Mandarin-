using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Player[] players;
	int currentPlayer = 0;
	bool gameOver = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void StartCurrentPlayerTurn(){
		if (currentPlayer >= players.Length) {
			currentPlayer = 0;
		}
		players[currentPlayer].TakeTurn ();
		currentPlayer++;
	}
}
