using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinesBtwnCentrosomes : MonoBehaviour {

	LineRenderer line;
	public GameObject[] verts;
	// Use this for initialization
	void Start () {
		line = gameObject.GetComponent<LineRenderer>();
		line.positionCount = verts.Length; 
		line.numCornerVertices = 20;
		line.startWidth = 0.05f;
		line.endWidth = 0.05f;
		int i = 0;
		foreach (GameObject vert in verts ) {
			line.SetPosition(i, vert.transform.position);
			i++;
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
