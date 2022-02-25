using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHit : MonoBehaviour
{
    bool canDie = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("started");
        StartCoroutine(TurkeyWait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //chicken.SetActive(false);

        Debug.Log("2222222222222222222");
        if (canDie==true && other.tag=="Cookable")
        {

            Debug.Log("255555555555555555555555");
        }
    }
    IEnumerator TurkeyWait()
    {
        yield return new WaitForSeconds(3);
        canDie = true;
       
    }
}
