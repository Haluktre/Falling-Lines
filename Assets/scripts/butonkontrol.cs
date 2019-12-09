using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class butonkontrol : MonoBehaviour {
	public GameObject bilardotopu,ikibilardoiki,ucbilardouc,dortbilardodort;
	// Use this for initialization
	void Start () {
		bilardotopu.gameObject.SetActive (true);
		ikibilardoiki.gameObject.SetActive (false);
		ucbilardouc.gameObject.SetActive (false);
		dortbilardodort.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void tiklama(){
		bilardotopu.gameObject.SetActive (true);
		ikibilardoiki.gameObject.SetActive (false);
		ucbilardouc.gameObject.SetActive (false);
		dortbilardodort.gameObject.SetActive (false);
	}
	public void tiklamaiki(){
		bilardotopu.gameObject.SetActive (false);
		ikibilardoiki.gameObject.SetActive (true);
		ucbilardouc.gameObject.SetActive (false);
		dortbilardodort.gameObject.SetActive (false);
	}
	public void tiklamauc(){
		bilardotopu.gameObject.SetActive (false);
		ikibilardoiki.gameObject.SetActive (false);
		ucbilardouc.gameObject.SetActive (true);
		dortbilardodort.gameObject.SetActive (false);
	}
	public void tiklamadort(){
		bilardotopu.gameObject.SetActive (false);
		ikibilardoiki.gameObject.SetActive (false);
		ucbilardouc.gameObject.SetActive (false);
		dortbilardodort.gameObject.SetActive (true);
	}
}
