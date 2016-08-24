using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public GameObject[] positions;
	public int currentPosition = 0;
	Vector3 velocity = Vector3.zero;
	int totalMoney = 3000;
	// Use this for initialization
	void Start () {
		transform.position =  new Vector3(positions[currentPosition].gameObject.transform.position.x,
										  transform.position.y,
									   	  positions[currentPosition].gameObject.transform.position.z);
		//InvokeRepeating ("Move", 2, 2.0f);
	}

	// Update is called once per frame
	void Update () {
		Vector3 newPosition = new Vector3(positions[currentPosition].gameObject.transform.position.x, transform.position.y, positions[currentPosition].gameObject.transform.position.z);
		transform.position = Vector3.SmoothDamp (transform.position,newPosition,ref velocity,0.3f);
	}

	public int Move()
	{
		
		currentPosition += Roll();
		if (currentPosition >= positions.Length) {
			currentPosition -= 36;
		}
		Debug.Log ("CurrentPosition: "+currentPosition);
		return currentPosition;
	}

	private int Roll(){
		int value = Random.Range (1, 7);
		Debug.Log ("Rolled: "+value);
		return value;
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
