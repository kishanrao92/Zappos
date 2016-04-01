using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player_movement : MonoBehaviour {
	public Rigidbody ball;
	public float speed;
	public int cnt;
	public Text countText;
	public Text winText;
	public Text time_text;
	public float time = 10;
	public GameObject level1;
	public GameObject level2;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Rigidbody> ();
		winText.text = " ";
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float move_h = Input.GetAxis ("Horizontal");
		float move_v = Input.GetAxis ("Vertical");

		Vector3 mv = new Vector3 (move_h, 0.00f, move_v);
		ball.AddForce (mv * speed);

			time -= Time.deltaTime;
		time_text.text = time.ToString ();
			if ( time <0 )
			{
			winText.text="YOU LOSE!";
			level1.SetActive (false);
			level2.SetActive (false);

			}


	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Pick Up"))
			{
				other.gameObject.SetActive(false);
				cnt+=1;
				SetText();
			}
	}

			void SetText(){
		countText.text = "SCORE:" + cnt.ToString ();
		if (cnt > 9) {
			
					winText.text="WINNER!";
		}
			}
}
