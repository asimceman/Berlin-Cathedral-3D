using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POI3 : MonoBehaviour
{
    public GameObject text;

    Ray ray;
    RaycastHit hit; 
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit)){
                if(hit.collider.tag == "text"){
                    if(text.activeSelf) text.SetActive(false);
                    else text.SetActive(true);
                }
            }
        }
        
    }
}
