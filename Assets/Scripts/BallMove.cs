using UnityEngine;
using System.Collections;

public class BallMove : MonoBehaviour {
    public Vector2 speed;
    public bool xPositive;
    public bool yPositive;
    public bool shouldMove = false;

    private Rigidbody ourRb;

	// Use this for initialization
	void Start () {
        ourRb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {
        Vector3 finalVel = new Vector3();
        if (shouldMove)
        {
            if (xPositive)
                finalVel.x = speed.x;
            else
                finalVel.x = -speed.x;
            if (yPositive)
                finalVel.z = speed.y;
            else
                finalVel.z = -speed.y;
        }
        ourRb.velocity = finalVel;
    }

    public void startBall()
    {
        float test = Random.Range(0.0f, 10.0f);
        if (test > 3.0f)
            xPositive = true;
        test = Random.Range(0.0f, 10.0f);
        if (test > 3.0f)
            yPositive = false;
        shouldMove = true;
    }
}
