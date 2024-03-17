using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalDoor : MonoBehaviour
{
    public GameObject rustkey; // Assign in inspector
    public GameObject door3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == rustkey)
        {
            OpenDoor();
        }
    }

    void OpenDoor()
    {
        door3.SetActive(false); // Disable the door, effectively "opening" it
        Debug.Log("Door Opened");
    }
}
