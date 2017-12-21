using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MeshFilter mf = GetComponent<MeshFilter>();
        mf.mesh.SetIndices(mf.mesh.GetIndices(0), MeshTopology.LineStrip, 0);
        MeshRenderer mr = GetComponent<MeshRenderer>();
        mr.material.color = new Color(0.4f, 0.4f, 0.9f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
