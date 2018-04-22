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
                    string[] line = new string[1];
                    bool displayed = true;

                    switch (hit.transform.gameObject.tag)
                    {
                        case "Cell":
                            dialogue.name = "Cell";
                            line[0] = "This is everything. The cells is enclosed by a plasma membrane and containing a membrane-bound nucleus and organelles.";
                            break;
                        case "Nucleolus":
                            dialogue.name = "Nucleolus";
                            line[0] = "The nucleolus can be though of as the brain of the Nucleus and takes up around 25% of the volume " +
                                "ribosomes are produced here.";
                            break;
                        case "Chromosomes":
                            dialogue.name = "Chromosomes";
                            line[0] = "A threadlike structure of nucleic acids and protein found in the nucleus of most living cells, carrying genetic information in the form of genes.";
                            break;
                        case "Miotic Spindle": //can't do this one since it is just lines
                            dialogue.name = "Miotic Spindle";
                            line[0] = "What a shame...";
                            break;
                        case "Nucleus": //envelope
                            dialogue.name = "Nucleus";
                            line[0] = "The brain of the cell that contains most of the cell's genetic material.";
                            break;
                        case "Chromatid":
                            dialogue.name = "Chromatid";
                            line[0] = "Each of the two threadlike strands into which a chromosome divides longitudinally during cell division. Each contains a double helix of DNA.";
                            break;
                        case "Centrosome":
                            dialogue.name = "Centrosomes";
                            line[0] = "An organelle near the nucleus of a cell that contains the centrioles and from which the spindle fibers develop in cell division. " +
                                "Centrioles involved in the development of spindle fibers in cell division.";
                            break;
                        default:
                            displayed = false;
                            break;
                    }

                    if (displayed)
                    {
                        dialogue.sentences = line;
                        box.SetActive(true);
                        //yield WaitForSeconds(1);
                        FindObjectOfType<DialogueManager>().DisplayOneSentence(dialogue);
                        //System.Threading.Thread.Sleep(10);
                        //box.SetActive(false);
                    }
                    //Debug.Log(box.GetComponent<RectTransform>().anchoredPosition);
                    //RectTransform assign_text_1RT = box.GetComponent<RectTransform>();
                    //box.GetComponent<RectTransform>().anchoredPosition = new Vector3(100.0f, 20000.0f, -1000.0f);
                    //box.GetComponent<RectTransform>().anchoredPosition = new Vector2(-734.0f, -200.0f);
                    //box.transform.position = new Vector3(-300.0f, -200.0f, 900.0f);

                    //Debug.Log(box.GetComponent<RectTransform>().anchoredPosition);
                    //float m_XAxis, m_YAxis;
                    //m_XAxis = box.GetComponent<RectTransform>().anchoredPosition.y;
                    //m_YAxis = box.GetComponent<RectTransform>().anchoredPosition.y;

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
