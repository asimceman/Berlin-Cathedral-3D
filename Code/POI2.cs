using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POI2 : MonoBehaviour
{
    public AudioSource audioSource;
    Ray ray;
    RaycastHit hit;
    public bool pauza;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource> ();
        audioSource.Pause();
        pauza = true; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit)){
                if(hit.collider.tag == "orgulje"){
                    if(pauza){
                        pauza = false;
                        audioSource.Play();
                    }
                    else if(!pauza){
                        pauza=true;
                        audioSource.Pause();
                        
                    }
                }
            }
        }
        
    }
}
