using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CashUI : MonoBehaviour {
	public Player player;
	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = "" + player.GetTotalMoney ();
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text> ().text = "" + player.GetTotalMoney ();
	}
}
