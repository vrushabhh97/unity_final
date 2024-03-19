using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Add this to use SceneManager

public class WinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider wincol)
    {
        if(wincol.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Scene_4"); // Load Scene_4 when the player triggers the collider
        }
    }
}
