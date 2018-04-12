using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMe : MonoBehaviour {
	
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
