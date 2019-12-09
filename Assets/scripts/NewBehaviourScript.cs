using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	public GameObject bircizgi,ikicizgi,uccizgi,dortcizgi;
	public UnityEngine.UI.Button buton,yenidenbasla;
	public GameObject panel,sayacc;
	public UnityEngine.UI.Text puandurumu,highscore,score;
	int cizgikontrol;
	int highscoreyazi;
	int high;
	float zamansayaci = 1f;
	GameObject one,two;
	string objismi;
	public bool oyundevam=false;
	public int puan = 0;
	int x = 0;
	int randomkontrol;
	private Rigidbody2D rg;
	// Use this for initialization
	void Start () {
		highscoreyazi = PlayerPrefs.GetInt("highscoreyazi");
		
	}
	
	// Update is called once per frame
	void Update () {
		PlayerPrefs.SetInt("highscoreyazi",highscoreyazi);
		score.text = "SCORE: " + puan;
		highscore.text = "HIGH SCORE: " + highscoreyazi;
		if(puan > highscoreyazi){
		highscoreyazi = puan;
		}
		if(puan==0){
		bircizgi.GetComponent<Rigidbody2D>().gravityScale = 0.2f;
		ikicizgi.GetComponent<Rigidbody2D>().gravityScale = 0.2f;
		uccizgi.GetComponent<Rigidbody2D>().gravityScale = 0.2f;
		dortcizgi.GetComponent<Rigidbody2D>().gravityScale = 0.2f;
		}
		cizgikontrol = Random.Range (1, 5);
		if(oyundevam){
			switch (cizgikontrol) {
			case 1:
				one = bircizgi;
				break;
			case 2:
				one = ikicizgi;
				break;
			case 3:
				one = uccizgi;
				break;
			case 4:
				one = dortcizgi;
				break;
			}
			//Spawn süresi
			zamansayaci -= Time.deltaTime;
			
			if (zamansayaci < 0f && one != two) {
				if(puan<20){
				Instantiate (one, new Vector3 (0, 7.81f, 0), Quaternion.Euler (0, 0, 0));
				zamansayaci = 2f;
				two = one;
				}
				if(puan<30 && puan>19){
				Instantiate (one, new Vector3 (0, 7.81f, 0), Quaternion.Euler (0, 0, 0));
				zamansayaci = 1.5f;
				two = one;
				}
				if(puan>29){
				Instantiate (one, new Vector3 (0, 7.81f, 0), Quaternion.Euler (0, 0, 0));
				zamansayaci = 1f;
				two = one;
				}
			}
			//Spawn süresi
			puandurumu.text = puan + "";
			}
			//oyun durunca ekran objeleri
			if (!oyundevam && x != 0) {
			puandurumu.gameObject.SetActive (false);
			score.gameObject.SetActive (true);
			highscore.gameObject.SetActive (true);
			yenidenbasla.gameObject.SetActive (true);
			panel.gameObject.SetActive (true);
			}
			//oyun durunca ekran objeleri
			
			//Oyun hızı kontrolü
			if(puan>=10 && 19>=puan){
			one.GetComponent<Rigidbody2D>().gravityScale = 0.3f;		
			}
			if(puan>=20 && 29>=puan){
			one.GetComponent<Rigidbody2D>().gravityScale = 0.4f;
			}
			if(puan>=30 && 39>=puan){
			one.GetComponent<Rigidbody2D>().gravityScale = 0.5f;
			}
			if(puan>=40 && 49>=puan){
			one.GetComponent<Rigidbody2D>().gravityScale = 0.6f;
			}
			if(puan>=50 && 59>=puan){
			one.GetComponent<Rigidbody2D>().gravityScale = 0.7f;
			}
			if(puan>=60){
			one.GetComponent<Rigidbody2D>().gravityScale = 0.8f;
			}
			//Oyun hızı kontrolü
		}
	//oyun başlayınca ekran objeleri
	public void oyunbaslat(){
		puandurumu.gameObject.SetActive (true);
		score.gameObject.SetActive (false);
		highscore.gameObject.SetActive (false);
		oyundevam = true;
		yenidenbasla.gameObject.SetActive (false);
		panel.gameObject.SetActive (false);
		buton.gameObject.SetActive (false);
		puan = 0;
		x++;
	}
	//oyun başlayınca ekran objeleri
}
