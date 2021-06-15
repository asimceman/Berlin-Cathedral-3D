using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitSlikaScript : MonoBehaviour
{

    public GameObject lijevi;
    public GameObject desni;
    public GameObject canvo;

    public void izadji(){
        lijevi.SetActive(true);
        desni.SetActive(true);
        canvo.SetActive(false);
    }
}
