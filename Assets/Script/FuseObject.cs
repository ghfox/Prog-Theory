using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseObject : MonoBehaviour
{
    //ENCAPSULATION
    [SerializeField]
    private GameObject fuseParticleObject;

    [SerializeField]
    private float fuseLength = 10;

    //ABSTRACTION
    public void OnClick()
    {
        fuseParticleObject.SetActive(true);
        Invoke("EndOfFuse",fuseLength);
        Debug.Log("OnClick");
    }

    protected virtual void EndOfFuse()
    {
        fuseParticleObject.SetActive(false);
    }

}
