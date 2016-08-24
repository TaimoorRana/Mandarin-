using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Player[] players;
	int currentPlayer = 0;
	bool gameOver = false;
	const int moneyLandValue = 100;

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
		players[currentPlayer].Move();
		if (players [currentPlayer].currentPosition % 3 == 1) {
			players [currentPlayer].CollectMoney (moneyLandValue);
		} else {
			players [currentPlayer].TakeChip ();
		}
		currentPlayer++;
	}
}
