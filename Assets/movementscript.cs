using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementscript : MonoBehaviour
{
 public bool isMoving=false;
    public float XMov;
    public float ZMov;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isMoving)
        gameObject.transform.position = new Vector3(XMov + gameObject.transform.position.x, gameObject.transform.position.y, ZMov + gameObject.transform.position.z);
    }
}
