using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float shootingForce = 10f;
    // Start is called before the first frame update
    void Start()
    {
		GetComponent<Rigidbody> ().AddForce (Vector3.forward * shootingForce);

    }
		
}
