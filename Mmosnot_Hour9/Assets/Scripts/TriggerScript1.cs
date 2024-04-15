using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + " Entered");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log(gameObject.name + " Exited");
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log(gameObject.name + " Inside");
    }
}
    
