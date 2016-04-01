using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;
	public float speed;
	private int count;
	public Text countText;
	public Text winText;
	public Text time_text;
	public float time = 10;
	public GameObject level1;
	public GameObject level2;

	void Start(){
		rb=GetComponent<Rigidbody>();
		SetCountText ();
		winText.text = "";

	}


	void FixedUpdate(){
		float move_horizontal = Input.GetAxis ("Horizontal");
		float move_vertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (move_horizontal, 0.0f, move_vertical);

		rb.AddForce (movement * speed);
		time_text.text = time.ToString ();
		time -= Time.deltaTime;
		if ( time <0 )
		{
			winText.text="YOU LOSE!";
			level1.SetActive (false);
			level2.SetActive (false);

		}


	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Pick Up"))
		{
			other.gameObject.SetActive(false);
			count = count + 1;
			SetCountText ();
		}
	}

	void SetCountText()
	{
		countText.text = "Count : " + count.ToString();
		if(count>11 && time>0)
		{
			winText.text= "WINNER!";
		}

		}
	}


