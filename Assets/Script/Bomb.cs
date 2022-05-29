using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Bomb : FuseObject
{
    [SerializeField]
    private GameObject blastObj;

    //POLYMORPHISM
    protected override void EndOfFuse()
    {
        Instantiate(blastObj, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
