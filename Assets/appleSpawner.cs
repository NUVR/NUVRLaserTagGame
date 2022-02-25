using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleSpawner : MonoBehaviour
{
    public GameObject apple;
    private int rand;
    private int rand2;
    //public Vector3 direction;

    //  public movementscript script;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("called");
        StartCoroutine(TurkeyWait());
    }

    // Update is called once per frame
    void again()
    {

        GameObject go = GameObject.Instantiate(apple);
        go.GetComponent<movementscript>().isMoving = true;
        rand = Random.Range(-3, 3);
        go.transform.position += new Vector3((float)rand / 2, 1.5f,0);
        StartCoroutine(TurkeyWait());
    }

    IEnumerator TurkeyWait()
    {
        rand2 = Random.Range(1, 4);
        yield return new WaitForSeconds((float)rand2);
        again();
    }
}
