using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private float sceneNumber;

    //public PlayerController playerController;

    void Start()
    {
        GetComponent<AudioSource>().Play();
    }
    public void WeaponSwitchModeSceneLoader(float sceneNumber)
    {

        switch (sceneNumber)
        {
            case 1:
                SceneManager.LoadScene("MissileScene", LoadSceneMode.Single);
                //playerController.wSwitch = 0;
                break;
            case 2:
                SceneManager.LoadScene("PlasmaScene", LoadSceneMode.Single);
                //playerController.wSwitch = 1;
                break;
            case 3:
                SceneManager.LoadScene("TacticalMissileScene", LoadSceneMode.Single);
                //playerController.wSwitch = 1;
                break;
            default:
                SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
                break;

        }


    }



}
