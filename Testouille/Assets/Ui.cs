using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Ui : MonoBehaviour
{
    public bool wesh;

    void Start()
    {
        wesh = true;   
    }

    void Update()
    {
        if(wesh)
        {
            Debug.Log("NAN");
        }
    }
}
