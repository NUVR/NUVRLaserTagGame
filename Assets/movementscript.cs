using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementscript : MonoBehaviour
{
 public bool isMoving=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isMoving)
        gameObject.transform.position = new Vector3(-0.01f+ gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }
}
