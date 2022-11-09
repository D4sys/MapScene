using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneExit : MonoBehaviour
{
    public string sceneToload;
    public string Exitname;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetString("LastExitName", Exitname);
            SceneManager.LoadScene(sceneToload);
        }
        
    }
}
