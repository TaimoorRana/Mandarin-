using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerBoard : MonoBehaviour {
	[SerializeField]
	List<Transform> chipLocations;
	List<Chip> chips = new List<Chip>();
	bool isVisible = false;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
	
	}

	public void addChip(Chip chip){
		chips.Add (chip);
		chip.gameObject.transform.parent = gameObject.transform;
		chip.gameObject.transform.position = chipLocations[chip.boardPosition].position;
		chip.gameObject.transform.rotation = chipLocations [chip.boardPosition].rotation;
		chip.gameObject.transform.rotation *= Quaternion.Euler (-90, 0, 0);
		chip.gameObject.transform.localScale = new Vector3(24.5f,24.5f,24.5f);
		string str = string.Concat("got ",chip.getColor()," ",chip.getName());
		Debug.Log (str);
	}
		
	public void toggleView(){
		isVisible = !isVisible;
		gameObject.GetComponent<MeshRenderer> ().enabled = isVisible;

		Renderer[] childrenRenderer = GetComponentsInChildren<Renderer> ();

		foreach(Renderer trans in childrenRenderer){
			trans.enabled = isVisible;
		}
	}
}
