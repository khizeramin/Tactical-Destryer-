using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoltMotion : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Quaternion quaternion;
    private float friction;
    private float originAxis;
    public Text fireText;



    void Update()
    {
        MissleLauncher();
    }
    public void MissleLauncher()
    {
        // Specially desgin Missile Lauching System.
        
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
        //GetComponent<Rigidbody>().rotation = new Quaternion(originAxis, originAxis, originAxis, 1);
        
    }


    //IEnumerator LittlePause()
    //{
    //    yield return new WaitForSeconds(2);
    //    fireText.text = "Fire... NOW!";
    //}
}
