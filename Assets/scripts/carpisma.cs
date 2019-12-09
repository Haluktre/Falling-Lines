using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpisma : MonoBehaviour {
	private NewBehaviourScript oyuncalistir;
	public GameObject calistir;
	float yokedici = 4f;
	void Start () {
		calistir = GameObject.Find ("cizgiler");
		oyuncalistir = calistir.GetComponent<NewBehaviourScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		yokedici -= Time.deltaTime;
		if(oyuncalistir.oyundevam){
		if (yokedici < 0f) {
			if(oyuncalistir.puan<=10){
			Destroy (this.gameObject);
			yokedici = 4f;
		}
		if(oyuncalistir.puan>=10){
			Destroy (this.gameObject);
			yokedici = 2f;
		}
		}
		}
		if(!oyuncalistir.oyundevam){
			Destroy (this.gameObject);
		}
}
}