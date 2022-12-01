using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class getStartSpell : MonoBehaviour
{
    [SerializeField]
    GameObject murDeSort;
    [SerializeField]
    GameObject rightHand;

    Vector3 baseposition;
    Quaternion baserotation;
    
    void Start() {
        baseposition = murDeSort.transform.position;
        baserotation = murDeSort.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger)>0){

        }else{
            //murDeSort.transform.position = Quaternion.Euler(rightHand.transform.position.x + (float)3.85, rightHand.transform.position.y + (float)1.2, rightHand.transform.position.z - (float)4.3) ;
            //murDeSort.transform.rotation = Quaternion.Euler(rightHand.transform.rotation.x, rightHand.transform.rotation.y + 40, rightHand.transform.rotation.z -45);
            murDeSort.transform.position = rightHand.transform.position + baseposition;
            //murDeSort.transform.rotation = rightHand.transform.rotation + baserotation;
        }
        
    }

    
}
