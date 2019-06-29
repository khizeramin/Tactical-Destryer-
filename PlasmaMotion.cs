using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlasmaMotion : MonoBehaviour
{
    public float speed;

    void Update()
    {   
        PlasmaLauncher();    
    }
    public void PlasmaLauncher()
    {
        //TODO: IMPLEMENT THE PLAMA SHOT lAUNCHEJR.
        //fireText.text = "FIRE!!!";
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
        
    }
}
