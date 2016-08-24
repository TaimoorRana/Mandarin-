using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public GameObject[] positions;
	public int currentPosition;
	Vector3 velocity = Vector3.zero;
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

	public void Move()
	{
		
		currentPosition += Roll();
		if (currentPosition >= positions.Length) {
			currentPosition = 0;
		}

	}

	private int Roll(){
		int value = Random.Range (1, 7);
		Debug.Log (value);
		return value;
	}

	public void TakeChip(){
		Debug.Log("Chip Collected");
	}

	public void CollectRent(){
		Debug.Log("Rent Collected");
	}

	public void TakeTurn(){
		Debug.Log("Taking my Turn");
		Move ();
		TakeChip ();

	}

}
