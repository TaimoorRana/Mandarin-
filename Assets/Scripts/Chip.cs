using UnityEngine;
using System.Collections;

public class Chip : MonoBehaviour {
	[SerializeField]
	string name;
	[SerializeField]
	string color;
	[SerializeField]
	bool crown;
	bool faceDown;
	private string ownerName = "";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public string getName(){
		return name;
	}

	public string getColor(){
		return color;
	}

	public bool isCrown(){
		return crown;
	}

	public string getOwnerName(){
		return ownerName;
	}

	public void setOwnerName(string name){
		ownerName = name;
	}
}
