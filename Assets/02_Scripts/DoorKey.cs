using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey : MonoBehaviour
{

    //[SerializeField] float startTime;
    //[SerializeField] Material newMat;
    //[SerializeField] Material oldMat;
    [SerializeField] GameObject key;
    //[SerializeField] string friendlyTag;
    [SerializeField] string key1;
    [SerializeField] int score;
    // Start is called before the first frame update
    void Start()
    {
        

       /* startTime = Time.time;
        oldMat = blade.GetComponent<MeshRenderer>().material;
        score = 0;*/
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnTriggerEnter(Collider other)
    {
        
        Debug.Log(other.gameObject.name);
        
        if (other.gameObject.tag == key1)
        {
            Destroy(other.gameObject);
           
            
            Debug.Log("Door Destroyed!!!");
            
        }
    }
}
