using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallScale : MonoBehaviour
{
    public GameObject Scaler;
   

    private Vector3 shrinkScale = new Vector3(.2f, .2f, .2f);

    void OnCollisionEnter(Collision col)//When Object Collides
    {
       
        Scaler.transform.localScale = shrinkScale;
      
    }
   
}