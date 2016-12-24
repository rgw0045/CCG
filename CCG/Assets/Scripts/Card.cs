using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {
	
	
	enum CardType {minion, spell};
	
	CardType type;
	public int cost;
	public string name;
	
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
		sql = "SELECT * FROM Cards WHERE Title = name";
		
		//here we would put the sql data readers and other things like that
		//still trying to figure out how to setup DB with unity
		
		
	}
	
	// Update is called once per frame
	void Update () {
	}
}
