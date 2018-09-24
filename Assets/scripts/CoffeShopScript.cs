using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CoffeShopScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entering new scene");
        SceneManager.LoadScene("Newcoffeescene");
    }
    // Use this for initialization
    void Start () {
		
	}
	
	}

