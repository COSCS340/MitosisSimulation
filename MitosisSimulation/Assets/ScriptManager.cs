using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptManager : MonoBehaviour {

	public GameObject nucleolus;
	public GameObject centreole1;
	public GameObject centreole2;
	public GameObject[] spindles1;
	public GameObject[] spindles2;
	public GameObject c2pos;
	public GameObject c3pos;
	public GameObject[] chromatids;

    public void InvokeFunction(int index)
    {
		switch (index) {
            case 1:
                TestFunction();
                break;
            case 2:
				Step1();
                TestFunction2();
                break;
			case 3:
				Step2();
				break;
			default:
                Debug.Log("Default");
                break;
		}
    }

	void Step1() {
		centreole2.transform.position = c2pos.transform.position;
		foreach ( GameObject spindle in spindles1 ) {
			spindle.SetActive(true);
		}
	}

	void Step2() {
		nucleolus.SetActive(false);
		foreach (GameObject chromatid in chromatids ) {
			chromatid.SetActive(true);
		}
		foreach (GameObject spindle in spindles1 ) {
			spindle.SetActive(false);
		}
		foreach (GameObject spindle in spindles2 ) {
			spindle.SetActive(true);
		}
		centreole2.transform.position = c3pos.transform.position;
	}

    void TestFunction()
    {
        Debug.Log("Total just called a function.");
    }

    void TestFunction2()
    { 
        Debug.Log("Total just called another function.");
    }
}
