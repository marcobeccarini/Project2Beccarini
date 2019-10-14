using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderAnim : MonoBehaviour
{
    
    public GameObject spider;//The spider
    private Animator anim;

    private void Start()
    {
        anim = spider.GetComponent<Animator>();
        

    }
    void OnCollisionEnter(Collision col)//When Object Collides
    {
        anim.SetTrigger("isdead");
    }
   
}

