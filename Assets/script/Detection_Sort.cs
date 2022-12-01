using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Detection_Sort : MonoBehaviour
{
    //cube.GetComponent<Renderer>().material.color = Color.red;


    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "cube-sort")
        {
            //cube.GetComponent<Renderer>().material.color = Color.red;
            print("enter");
        }
    }

    void OnTriggerStay(Collider other) {
        if(other.gameObject.tag == "cube-sort")
        {
            //cube.GetComponent<Renderer>().material.color = Color.red;
            print("stay");
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "cube-sort")
        {
            print("exit");
        }
    }
}
