using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunkontrolcusu : MonoBehaviour {
	private NewBehaviourScript oyuncalistir;
	public GameObject calistir;
	string objismi;

	void Start () {
		calistir = GameObject.Find ("cizgiler");
		oyuncalistir = calistir.GetComponent<NewBehaviourScript> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D	(Collision2D cls){
		objismi = cls.gameObject.name;
		if (objismi == "bilardotopu" || objismi == "ikibilardoiki" || objismi == "ucbilardouc" || objismi == "dortbilardodort") {
			oyuncalistir.oyundevam = false;
		}
		if (objismi == "sayac"){
			oyuncalistir.puan++;
		}
	}
}
