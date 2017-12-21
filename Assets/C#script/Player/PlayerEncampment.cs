using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEncampment : Singleton<PlayerEncampment> {
    protected PlayerEncampment() { }
    Vector3 pos;

    public Vector3 GetPos()
    {
        pos = transform.position;
        return pos;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
