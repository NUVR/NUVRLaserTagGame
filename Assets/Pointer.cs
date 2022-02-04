using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{


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
        //chicken.SetActive(false);

        Debug.Log(other.gameObject.tag);
       if (other.tag == "Cookable")
        {
     
            other.gameObject.SetActive(false);

      }
    }
}
