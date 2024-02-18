using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour

{


    [SerializeField] float startTime;
    [SerializeField] Material newMat;
    [SerializeField] Material oldMat;
    [SerializeField] GameObject blade;
    [SerializeField] string friendlyTag;
    [SerializeField] string enemyTag;
    [SerializeField] int score;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world");

        startTime = Time.time;
        oldMat = blade.GetComponent<MeshRenderer>().material;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hey() {
        Debug.Log("Hey");
    }


    private void OnTriggerEnter(Collider other)
    {
        Hey();
        Debug.Log(other.gameObject.name);
        if (other.gameObject.tag == friendlyTag) {
            blade.GetComponent<MeshRenderer>().material = newMat;
        }
        if (other.gameObject.tag == enemyTag)
        {
            Destroy(other.gameObject);
            score++;
            if (score >= 3) {
                Debug.Log("You Won!!!");
            }
        }
    }
}
