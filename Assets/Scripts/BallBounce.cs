using UnityEngine;
using System.Collections;

public enum shouldBounce
{
    NONE,XREF,YREF,BOTH
};
public enum xRef
{
    NONE,REF,POS,NEG
};
public enum yRef
{
    NONE,REF,POS,NEG
};


[System.Serializable]
public struct enumsPerColl
{
    public shouldBounce bounce;
    public xRef xReflection;
    public yRef yReflection;
}

public class BallBounce : MonoBehaviour {

    public enumsPerColl[] enums;

    public BoxCollider topBot;
    public BoxCollider leftRight;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
