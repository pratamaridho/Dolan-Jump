﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour {

	[SerializeField]private PlayerController playerController;

	void OnTriggerEnter2D(Collider2D other){
		
		if(other.tag == "Player"){

			playerController.playerHealtSekarang += 40;
			Destroy(gameObject);
		}
	}
}
