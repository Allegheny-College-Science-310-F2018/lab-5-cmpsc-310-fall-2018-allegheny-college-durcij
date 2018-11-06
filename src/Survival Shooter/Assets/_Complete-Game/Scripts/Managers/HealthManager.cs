using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthManager : MonoBehaviour {

	public static int health;


	Text text;


	void Awake ()
	{
			text = GetComponent <Text> ();
			health = 100;
	}


	void Update ()
	{
			if(health < 0)
			{
				text.text = "HP: 0";
			} else {
			text.text = "HP: " + health;
			}
	}
}
