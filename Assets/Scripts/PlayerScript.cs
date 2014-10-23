using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//left and right movement
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.position = Vector3.MoveTowards(transform.position, transform.position - new Vector3(4f,0,0), Time.deltaTime * 2);
			transform.localScale = new Vector3(-4,4,1);
		}
		else if (Input.GetKey(KeyCode.RightArrow)) {
			transform.position = Vector3.MoveTowards(transform.position, transform.position + new Vector3(4f,0,0), Time.deltaTime * 2);
			transform.localScale = new Vector3(4,4,1);
		}

		//controls for jumping
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			gameObject.rigidbody2D.AddForce(new Vector2(0,256.0f));

			//transform.position = Vector3.MoveTowards(transform.position, transform.position + new Vector3(0,1048f,0), Time.deltaTime * 2);
		
		}
	}
}
