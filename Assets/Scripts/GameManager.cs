using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject[] players;
	public Transform[] locations;
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
		int playerNewPosition = Roll () + players [currentPlayer].GetComponent<Player>().positionNumber;

		if (playerNewPosition >= locations.Length) {
			playerNewPosition -= locations.Length;
		}
		players [currentPlayer].GetComponent<Player> ().positionNumber = playerNewPosition;
		players[currentPlayer].GetComponent<Player>().Move(locations[playerNewPosition]);
		if (playerNewPosition % 3 == 1) {
			players [currentPlayer].GetComponent<Player>().CollectMoney (moneyLandValue);
		} else {
			players [currentPlayer].GetComponent<Player>().TakeChip ();
		}
		currentPlayer++;
	}

	private int Roll(){
		int value = Random.Range (1, 7);
		Debug.Log ("Rolled: "+value);
		return value;
	}
}
