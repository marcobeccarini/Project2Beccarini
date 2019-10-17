using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallScale : MonoBehaviour
{
    public GameObject Scaler;
   

    private Vector3 shrinkScale = new Vector3(.3f, .3f, .3f);

    void OnCollisionEnter(Collision col)//When Object Collides
    {
       
        Scaler.transform.localScale = shrinkScale;
        Scaler.transform.position = new Vector3(2.87f, 0f, 1.48f);
    }
   
}