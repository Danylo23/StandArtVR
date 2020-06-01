using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	public float speed = 3.5f;
	public float jump = 10f;
	public float rotatingSpeed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
	{
		if (Input.GetKey ("right")) {
			transform.RotateAround (transform.position, Vector3.up, rotatingSpeed * Time.deltaTime);
		}
		if (Input.GetKey ("left")) {
			transform.RotateAround (transform.position, Vector3.up, -rotatingSpeed * Time.deltaTime);
		}
		if (Input.GetKeyDown ("space")) {
			GetComponent<Rigidbody> ().AddForce (0, jump, 0);
		}
		if (Input.GetKey ("up")) {
			transform.position += transform.forward * speed * Time.deltaTime;
		}
	}
	void OnCollisionEnter (Collision collision){
		if (collision.transform.name == "Cube") {
			Debug.Log ("Hit the floor");
		}

	}
}