using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using static Row;
using static spellAlgo;


public class getStartSpell : MonoBehaviour
{
    [SerializeField]
    GameObject murDeSort;

    [SerializeField]
    GameObject rightHand;

    [SerializeField]
    GameObject activeWand;

    [SerializeField]
    List<SObjSpell> spellList;

    [SerializeField]
    SObjSpell spellActive;

    [SerializeField]
    Row[] spell = new Row[5];

    public ParticleSystem system;

    private float waitTime = 2f;
    private float count = 2.0f;

    [SerializeField]
    private bool releaseSpell = false;


    void DoEmit()
    {
        Material particleMaterial = new Material(Shader.Find("Particles/Standard Unlit"));
        var go = new GameObject("Particle System");
        go.transform.Rotate(0, 0, 0); // Rotate so the system emits upwards.
        go.transform.localPosition = new Vector3(0, 0, 0.8f);
        system = go.AddComponent<ParticleSystem>();
        go.GetComponent<ParticleSystemRenderer>().material = particleMaterial;
        var mainModule = system.main;
        mainModule.startColor = Color.green;
        mainModule.startSize = 0.05f;
        go.transform.SetParent(rightHand.transform, true);
        Destroy(FindGameObjectsWithName("Particle System")[0]);
        
    }
    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger) > 0)
        {
            releaseSpell = true;
            count += Time.deltaTime;
            murDeSort.transform.SetParent(null, true);

            if (count >= waitTime)
            {
                
                //DoEmit();
                count =0.0f;
            }
        }
        else
        {
            if (releaseSpell)
            {
                releaseSpell = false;

                List<GameObject> list = new List<GameObject>();
                
                
                for (int i = 4; i >= 0 ; i--)
                {
                    for (int j = 4; j >= 0; j--)
                    {
                        Debug.Log(i * 5 + j);
                        if (murDeSort.transform.GetChild(i*5+4-j).gameObject.tag == "active")
                        {
                            spell[i].Lines[j] = true;
                        }else
                        {
                            spell[i].Lines[j] = false;
                        }
                    }
                }
                SObjSpell spellSend = new SObjSpell();
                spellSend.spell = spell;
                SObjSpell spellFound = FindSpell(spell, spellList);
                Debug.Log(spellFound != null ? spellFound.spellName : "a pas trouvé");
            }
            murDeSort.transform.SetParent(rightHand.transform, true);
            murDeSort.transform.localPosition = new Vector3((float) - 0.3, (float) - 0.3, (float) 0.8);
            murDeSort.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }

    public GameObject[] FindGameObjectsWithName(string name){
         int a = GameObject.FindObjectsOfType <GameObject>().Length;
         GameObject[] arr=new GameObject[a];
         int FluentNumber = 0;
         for (int i=0; i<a; i++) {
             if (GameObject.FindObjectsOfType<GameObject> () [i].name == name) {
                 arr [FluentNumber] = GameObject.FindObjectsOfType<GameObject> () [i];
                 FluentNumber++;
             }
         }
         Array.Resize (ref arr, FluentNumber);
         return arr;
    }
}
