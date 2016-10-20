using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text leftScore, rightScore;
    public Collider left, right;

    public int leftValue = 0, rightValue = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        leftScore.text = leftValue.ToString();
        rightScore.text = rightValue.ToString();	
	}

}
