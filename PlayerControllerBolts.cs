using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControllerBolts : MonoBehaviour
{
    public float speed;
    public float tilt;
    public Transform[] shotSpawn;
    public float fireRate;
    private float nextFire;
    public GameObject boltShots;
    
    
    void Update()
    {
        // TODO: place a Condition to switch between weapons.
        // An integer such as i=1 or i=2 can be placed for the instantiating the shots.
        //StartCoroutine(WeaponAssault());
        WeaponSwitch();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
				SceneManager.LoadScene("MainScene");
        (}
    }
		informat ls isu upper name 
    void FixedUpdate()	
    {	
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical"); 
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().velocity = movement * speed;

        GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);
    }

    public void WeaponSwitch()
    {
        
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            for (int shotspawn = 0; shotspawn < shotSpawn.Length; shotspawn++)
            {
                nextFire = Time.time + fireRate;
                Instantiate(boltShots, shotSpawn[shotspawn].position, shotSpawn[shotspawn].rotation);
            }
            GetComponent<AudioSource>().Play();
        }
                
             
    }
    
}
