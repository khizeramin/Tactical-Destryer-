using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TacticalBoltMotion : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private float launchSpeed;
    private Quaternion quaternion;
    private float friction;
    private float originAxisX;
    private float originAxisY;
    private float originAxisZ;
    public Text fireText;
    void Start()
    {
        launchSpeed = 10;
        friction = 0.5f;
        originAxisX = 0.0f;
        originAxisY = 0.0f;
        originAxisZ = 0.0f;
        quaternion = new Quaternion();
        //GetComponent<Rigidbody>().velocity = transform.forward * speed;
        //GetComponent<Rigidbody>().velocity = transform.forward * -launchSpeed;

    }
    
    void Update()
    {
        TacticalMissleLauncher();    
    }
    public void TacticalMissleLauncher()
    {
        // Specially desgin Missile Lauching System.
        float nullSpeed = 0.0f;

        if (launchSpeed == nullSpeed)
        {
            GetComponent<Rigidbody>().velocity = transform.forward * speed;
            GetComponent<Rigidbody>().rotation = new Quaternion(originAxisX, originAxisY, originAxisZ, 1);
        }

        else
        {
            GetComponent<Rigidbody>().velocity = transform.forward * -launchSpeed;
        }

        launchSpeed = launchSpeed - friction;
    }


    //IEnumerator LittlePause()
    //{
    //    yield return new WaitForSeconds(2);
    //    fireText.text = "Fire... NOW!";
    //}
}
