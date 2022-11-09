using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public static PlayerScript instance;
    //[SerializeField] private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        if (instance != null )
        {
            Destroy(gameObject);
        }
        else {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
        //Player = gameObject.Getcomponent("ThirdPersonController" ) as ScriptableObject;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
