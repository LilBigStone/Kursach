using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BuySlowTime : MonoBehaviour {

	public Text count, coins;

	void Start () {
		count.text = PlayerPrefs.GetInt ("Slow Time").ToString ();
	}

	void OnMouseUpAsButton () {
		if (PlayerPrefs.GetInt ("Coins") > 50) {
			PlayerPrefs.SetInt ("Slow Time", PlayerPrefs.GetInt ("Slow Time") + 1);
			count.text = PlayerPrefs.GetInt ("Slow Time").ToString ();
			PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt ("Coins") - 50);
			coins.text = PlayerPrefs.GetInt ("Coins").ToString ();
			
		}
		
	}

}
