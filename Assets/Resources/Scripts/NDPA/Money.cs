﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Money : MonoBehaviour {

	public float couste = 126;  
	public static float profit; 
	public Text SocialText;
	
	void Start () 
	{
		SocialText = gameObject.GetComponent<Text>();
	}

	void Update () 
	{
		SocialText.text = (profit-couste).ToString();

		/*if (couste <= -500) {
		
			Debug.Log("Voce e um merda");
		} */

	}
}