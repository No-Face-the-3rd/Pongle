using UnityEngine;
using System.Collections;

public class BallMove : MonoBehaviour {
    public float startSpeed;
    private float speed;
    public Vector2 Dir;
    public bool shouldMove = false;
    public float startTime;
    private float curTime;

    private Rigidbody ourRb;

	// Use this for initialization
	void Start () {
        resetBall();
        ourRb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {
        if (curTime > startTime && !shouldMove)
            startBall();
         curTime += Time.deltaTime;
        Dir = new Vector2( ourRb.velocity.normalized.x, ourRb.velocity.normalized.z);
    }

    void FixedUpdate()
    {
        if (!shouldMove)
            ourRb.velocity = Vector3.zero;
    }

    public void startBall()
    {
        float test = Random.Range(0.0f, 2 * Mathf.PI);
        Dir = new Vector2(Mathf.Cos(test), Mathf.Sin(test));
        shouldMove = true;
        Vector3 finalVel = new Vector3();
        test = Random.Range(0.0f, 1.0f);
        if (test > 0.5f)
            finalVel.x += speed * Dir.x;
        else
            finalVel.x -= speed * Dir.x;
        test = Random.Range(0.0f, 1.0f);
        if (test < 0.5f)
            finalVel.z += speed * Dir.y;
        else
            finalVel.z -= speed * Dir.y;
        ourRb.velocity = finalVel;

    }

    public void resetBall()
    {
        curTime = 0.0f;
        speed = startSpeed;
        shouldMove = false;
        transform.position = new Vector3();
    }

    void OnCollisionEnter(Collision collision)
    {
        speed += speed * 0.05f;
        Vector3 finalVel = ourRb.velocity.normalized;
        if (Mathf.Abs(finalVel.x) < 0.5)
            finalVel.x = finalVel.x / Mathf.Abs(finalVel.x);
        ourRb.velocity = finalVel.normalized * speed;
    }

    void OnTriggerEnter(Collider other)
    {
        Score score = other.GetComponent<Score>();
        if(score)
        {
            if (other == score.left)
                score.rightValue++;
            else if (other == score.right)
                score.leftValue++;
            resetBall();
        }
    }

}
