using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoScript : MonoBehaviour
{

    public GameObject panel1;
    public GameObject panel2;
    public GameObject canvasSlika;

    public void infoPritisak(){
        panel1.SetActive(false);
        panel2.SetActive(false);
        canvasSlika.SetActive(true);
    }

}
