using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour {

	Material mat;
	public bool fade = false;
	public float speed = 0.1f;
	public bool fadeup = false;	//fading object in or out
	// Use this for initialization
	void Start () {
		mat = gameObject.GetComponent<Renderer>().material;
		if (mat.color.a == 0 ) {
			fadeup = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if ( fade) {
			if ( fadeup == false ) {
				if ( mat.color.a > 0 ) {
					Color color = mat.color;
					color.a = color.a - speed * Time.deltaTime;
					mat.color = color;
				} else {
					fade = false;
					gameObject.SetActive(false);
				}
			} else {
				if ( mat.color.a < 150 ) {
					Color color = mat.color;
					color.a = color.a + speed * Time.deltaTime;
					mat.color = color;
				} else {
					fade = false;
				}
			}
		}
	}
}
