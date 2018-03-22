using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptManager : MonoBehaviour {

	public GameObject nucleolus;
	public GameObject centreole1;
	public GameObject centreole2;
	public GameObject[] spindles;

    public void InvokeFunction(int index)
    {
       switch (index)
        {
            case 1:
                TestFunction();
                break;
            case 2:
                TestFunction2();
                break;
            default:
                Debug.Log("Default");
                break;
        }
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
