using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public GameObject[] players;
	public Transform[] locations;
	public List<Chip> unassignedChips;
	public List<Chip> assignedChips;
	int currentPlayer = 0;
	const int moneyLandValue = 100;
	bool passedAPlayer = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void StartCurrentPlayerTurn(){
		if (passedAPlayer) {
			currentPlayer--;
			movePlayer ();
			currentPlayer++;
			passedAPlayer = false;
			return;
		}
		// go back to player 1 if out of bounds
		if (currentPlayer >= players.Length) {
			currentPlayer = 0;
		}
		int playerPreviousPosition = players [currentPlayer].GetComponent<Player>().positionNumber;

		int playerNewPosition = movePlayer ();


		foreach (GameObject player in players) {
			if (player.GetComponent<Player>() != players [currentPlayer].GetComponent<Player>()) {
				if(playerPreviousPosition < player.GetComponent<Player>().positionNumber && playerNewPosition > player.GetComponent<Player>().positionNumber){
					Debug.Log("passed a player");
					passedAPlayer = true;
				}
			}
			
		}
		if (!passedAPlayer) {
			// if the player lands on money position, then collect money, else collect a chip
			if (playerNewPosition % 3 == 1) {
				players [currentPlayer].GetComponent<Player> ().CollectMoney (moneyLandValue);
			} else {
				// get chip
				if (unassignedChips.Count != 0) {
					Chip chip = getRandomChip ();
					players [currentPlayer].GetComponent<Player> ().TakeChip (chip);
				} else {
					Debug.Log("No More Chips");
				}

			}
		} else {
			Debug.Log("Collecting chip from PLAYER");
		}

		// go to next player
		currentPlayer++;
	}

	private int Roll(){
		int value = Random.Range (1, 7);
		Debug.Log ("Rolled: "+value);
		return value;
	}

	public int movePlayer(){
		// calculate the new position
		int playerNewPosition = Roll () + players [currentPlayer].GetComponent<Player>().positionNumber;

		// don't go over the location quantity
		if (playerNewPosition >= locations.Length) {
			playerNewPosition -= locations.Length;
		}

		// set the position in the player object
		players [currentPlayer].GetComponent<Player> ().positionNumber = playerNewPosition;

		// move the player
		players[currentPlayer].GetComponent<Player>().Move(locations[playerNewPosition]);

		return playerNewPosition;
	}

	private Chip getRandomChip(){
		int value = Random.Range (0, unassignedChips.Count);

		assignedChips.Add (unassignedChips[value]);
		unassignedChips.Remove (unassignedChips [value]);
		return assignedChips[assignedChips.Count - 1];
	}

}
