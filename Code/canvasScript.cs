using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasScript : MonoBehaviour
{
    public GameObject lijevi;
    public GameObject desni;
    public GameObject canvo;
    void Start()
    {
        lijevi.SetActive(true);
        desni.SetActive(true);
        canvo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
