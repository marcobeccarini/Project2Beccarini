using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    public int minForce;//The Minimum Force Required To Break The Object
    public GameObject bouncer;//The Broken Object

    void OnCollisionEnter(Collision col)//When Object Collides
    {
        print("The Magnitude Was " + col.relativeVelocity.magnitude.ToString());//Print Out The Magnitude Of The Collision
        if (col.relativeVelocity.magnitude >= minForce)//If The magnitude Of The Collision Is Equal or Greater Than The Minimum Force Required TO Break It
        {
            Bounce();
        }
    }
    void Bounce()
    {

        bouncer.GetComponent<AudioSource>().Play();

    }
}