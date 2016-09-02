using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerBoard : MonoBehaviour {
	List<Chip> chips = new List<Chip>();
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}

	public void addChip(Chip chip){
		chips.Add (chip);
		chip.gameObject.transform.position = gameObject.transform.position;
		string str = string.Concat("got ",chip.getColor()," ",chip.getName());
		Debug.Log (str);
	}
}
