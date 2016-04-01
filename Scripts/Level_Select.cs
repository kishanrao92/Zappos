using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Level_Select : MonoBehaviour {
	public UnityEngine.UI.Slider slider;
	public GameObject level1;
	public GameObject level2;
	public Text level_text;
	public GameObject time;
	// Use this for initialization
	void Start () {

	}

	void Update () {

		if (Input.GetButtonDown("SliderUp")) {

			slider.value +=1.00f;
		}
		if (Input.GetButtonDown("SliderDown")) {

			slider.value -=1.00f;
		}
		//slider_val = slider.value;

		//change_text (temp);

		//Debug.Log (slider_val);
	}


	public void set_level(float temp){
		if (temp==0.00f) {
			
			level2.SetActive (true);
			time.SetActive (true);
			level_text.text = "EASY";

		} else if (temp==1.00f) {
			
			level2.SetActive (false);
			level1.SetActive (true);
			time.SetActive (true);
			level_text.text = "HARD";
		}	
	}
	
	// Update is called once per frame

}
