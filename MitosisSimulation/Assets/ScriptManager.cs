using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptManager : MonoBehaviour {

	public GameObject nucleolus;
	public GameObject centreole1;
	public GameObject centreole2;
	public GameObject[] spindles1;
	public GameObject[] spindles2;
	public GameObject c2pos;
	public GameObject c3pos;
	public GameObject[] chromatids;
	public GameObject envelope;
	public GameObject[] chromosomes;
	public GameObject[] chromopoints;
	public GameObject[] daughterchromosomes;
	public GameObject cell;

    public void Update()
    {
        //Checking to see if the user wants to exit to the main menu
        if (Input.GetKey(KeyCode.Escape) && Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }

    public void InvokeFunction(int index)
    {
		switch (index) {
            case 3:
				Step1();
                break;
			case 4:
				Step2();
				break;
			case 5:
				Step3();
				break;
			case 6:
				Step4();
				break;
			case 7:
				Step5();
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
		nucleolus.SetActive(false);
		foreach (GameObject chromatid in chromatids ) {
			chromatid.SetActive(true);
		}
	}

	void Step2() {
		foreach (GameObject chromatid in chromatids ) {
			chromatid.SetActive(false);
		}
		foreach (GameObject spindle in spindles1 ) {
			spindle.SetActive(false);
		}
		foreach (GameObject spindle in spindles2 ) {
			spindle.SetActive(true);
		}
		foreach (GameObject chromo in chromosomes ) {
			chromo.SetActive(true);
		}
		centreole2.transform.position = c3pos.transform.position;
		envelope.SetActive(false);
	}

	void Step3() {
		int i;
		GameObject chromo;
		GameObject point;
		for ( i = 0; i < chromosomes.Length; i++ ) {
			chromo = chromosomes[i];
			point = chromopoints[i];
			chromo.transform.position = point.transform.position; 
		}

	}

	void Step4() {
		foreach ( GameObject chromo in chromosomes ) {
			chromo.SetActive(false);
		}
		foreach (GameObject spindle in spindles2 ) {
			spindle.SetActive(false);
		}
		foreach (GameObject daughter in daughterchromosomes ) {
			daughter.SetActive(true);
		}
		Vector3 newscale = cell.transform.localScale;
		newscale.y = 12f;
		cell.transform.localScale = newscale;

	}

	void Step5() {
		Vector3 newscale = cell.transform.localScale;
		newscale.y = 10f;
		cell.transform.localScale = newscale;
		envelope.SetActive(true);
		foreach ( GameObject chromatid in chromatids ) {
			chromatid.SetActive(true);
		}
		foreach (GameObject daughter in daughterchromosomes ) {
			daughter.SetActive(false);
		}
		Vector3 centreole1pos = centreole1.transform.position;
		centreole1pos.y += 5.5f;
		centreole1.transform.position = centreole1pos;

		Vector3 centreole2pos = centreole2.transform.position;
		centreole2pos.y -= 5.4f;
		centreole2.transform.position = centreole2pos;

		GameObject newcell = Instantiate(cell);

		Vector3 higherpos = cell.transform.position;
		Vector3 lowerpos = cell.transform.position;
		lowerpos.y -= 5.0f;
		higherpos.y += 5.0f;
		newcell.transform.position = higherpos;
		cell.transform.position = lowerpos;

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
