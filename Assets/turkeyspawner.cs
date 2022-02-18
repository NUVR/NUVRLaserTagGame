using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turkeyspawner : MonoBehaviour
{
    public GameObject turkey;
    private int rand;
    private int rand2;

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

        GameObject go = GameObject.Instantiate(turkey);
        go.GetComponent<movementscript>().isMoving = true;
        rand = Random.Range(-3, 3);
        go.transform.position += new Vector3(0, 1.5f, (float)rand/2);
        StartCoroutine(TurkeyWait());
    }

    IEnumerator TurkeyWait()
    {
        rand2 = Random.Range(1, 4);
        yield return new WaitForSeconds((float)rand2);
        again();
    }
}
