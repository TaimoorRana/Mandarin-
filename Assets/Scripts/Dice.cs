﻿using UnityEngine;
using System.Collections;

public class Dice : MonoBehaviour {
	public GameObject gameManager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		gameManager.GetComponent<GameManager>().StartCurrentPlayerTurn ();
	}
}
