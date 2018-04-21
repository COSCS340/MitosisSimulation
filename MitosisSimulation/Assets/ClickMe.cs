using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMe : MonoBehaviour {

    public Dialogue dialogue;
    public GameObject box;
    public GameObject canvas;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit[] hits;
            hits = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition), 100.0f);

            for (int i = 0; i < hits.Length; i++)
            {
                RaycastHit hit = hits[i];
                //PrintName(hit.transform.gameObject);
                if (i == hits.Length - 1) {
                    print(hit.transform.gameObject.tag);

                    dialogue = new Dialogue();
                    if (hit.transform.gameObject.tag == "Cell")
                    {
                        dialogue.name = "CELL";
                    }
                    else
                    {
                        dialogue.name = "TEST";
                    }
                    //#################################################################################
                    
                    string[] line = new string[1];
                    line[0] = "This may work";
                    dialogue.sentences = line;


                    //box = GameObject.Find("TextPopUp"); //does not work for inactive objects
                    box.SetActive(true);
                    //canvas.transform.position = hit.transform.position;
                    //box.transform.position = hit.transform.position;
                    //box.transform.position = Vector3.MoveTowards(box.transform.position, hit.transform.position, 10 * Time.deltaTime);
                    //box.transform.position = Vector3.Lerp(box.transform.position, hit.transform.position, 1);


                    FindObjectOfType<DialogueManager>().DisplayOneSentence(dialogue);
                    //#################################################################################
                }
            }
                /*RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit, 100.0f))
                {
                    if (hit.transform != null)
                    {
                        PrintName(hit.transform.gameObject);
                    }
                }*/
        }
	}
    //Unused
    private void PrintName(GameObject obj)
    {
        print(obj.name);
    }
}
