using UnityEngine;
using System.Collections;


public class PaddleMove : MonoBehaviour {
    public KeyCode up, down;
    public float speed;
    public float max, min;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 finalVel = new Vector3();
        if (Input.GetKey(up) && transform.position.z < max)
            finalVel.z += speed * Time.deltaTime;
        if (Input.GetKey(down) && transform.position.z > min)
            finalVel.z -= speed * Time.deltaTime;

        transform.Translate(finalVel);
	}
}
