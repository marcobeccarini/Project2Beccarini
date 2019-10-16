using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormScale : MonoBehaviour
{
    public GameObject Scaler;


    private Vector3 NormScaler = new Vector3(1f, 1f, 1f);

    void OnCollisionEnter(Collision col)//When Object Collides
    {
            Scaler.transform.localScale = NormScaler;
            Scaler.transform.position = new Vector3(1f, 0f, 2.30f);

    }

}