using UnityEngine;
using System.Collections;


public class Dice : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		roll ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void roll(){

		Debug.Log (Random.Range (1, 7));
	}
}
