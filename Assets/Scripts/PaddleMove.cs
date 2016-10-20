using UnityEngine;
using System.Collections;


public class PaddleMove : MonoBehaviour {
    public KeyCode up, down;
    public float speed;
    public float max, min;

    private Rigidbody ourRB;
	// Use this for initialization
	void Start () {
        ourRB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 finalVel = new Vector3();
        if (Input.GetKey(up))// && transform.position.z < max)
            finalVel.z += speed;
        if (Input.GetKey(down))// && transform.position.z > min)
            finalVel.z -= speed;
        if (finalVel.magnitude > 0.0f)
            ourRB.isKinematic = false;
        else
            ourRB.isKinematic = true;
        ourRB.velocity = finalVel;
	}
}
