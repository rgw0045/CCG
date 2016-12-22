using UnityEngine;
using System.Collections;

public class CardTypes : MonoBehaviour {

	enum CardType {minion, spell};

	CardType type;
	public int cost;

	//minion card variables
	public int health;
	public int attack;

	//spell card variables
	public string description;
	public string function;

	// Use this for initialization
	void Start () {
		//retrieve card info from DB
		string sql = "";


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
