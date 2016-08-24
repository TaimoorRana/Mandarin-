using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


	Vector3 velocity = Vector3.zero;
	int totalMoney = 3000;
	public Transform startPosition;
	public int positionNumber = 0;
	Transform currentPosition;

	// Use this for initialization
	void Start () {
		transform.position = startPosition.position;
		currentPosition = startPosition;
	}

	// Update is called once per frame
	void Update () {
		Vector3 newPosition = new Vector3(currentPosition.position.x, transform.position.y, currentPosition.position.z);
		transform.position = Vector3.SmoothDamp (transform.position,newPosition,ref velocity,0.3f);
	}

	public void Move(Transform newPosition)
	{
		currentPosition = newPosition;

		/*
		currentPosition += Roll();
		if (currentPosition >= positions.Length) {
			currentPosition -= 36;
		}
		Debug.Log ("CurrentPosition: "+currentPosition);
		*/


	
	}





	public void TakeChip(){
		Debug.Log("Chip Collected");
	}

	public void CollectRent(){
		Debug.Log("Rent Collected");
	}
		

	public int GetTotalMoney(){
		return totalMoney;
	}

	public void CollectMoney(int moneyCollected){
		Debug.Log("CollectMoney");
		totalMoney += moneyCollected;
	}

	public void PayRent(int rentAmount){
		Debug.Log("PayRent");
		totalMoney -= rentAmount;
	}

	public void PayAuction(int auctionAmount){
		Debug.Log("PayAuction");
		totalMoney -= auctionAmount;
	}
}
