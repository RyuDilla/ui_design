using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    public Vector3 localGravity;

	private Rigidbody rb;

    
    [SerializeField] float gravityScale;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody>();
		rb.useGravity = false;
        gravityScale = PlayerPrefs.GetFloat("GravityScale");
	}

	void FixedUpdate () {
		setLocalGravity ();
	}

	void setLocalGravity(){
		rb.AddForce (Vector3.down * gravityScale, ForceMode.Acceleration);
	}
}
