using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderDeath : MonoBehaviour
{
    public GameObject SpiderAlive;//The Broken Object
    public GameObject SpiderDead;

    void OnCollisionEnter(Collision col)//When Object Collides
    {
        SpiderAlive.SetActive(false);
        SpiderDead.SetActive(true);

    }
   
}
