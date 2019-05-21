using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightFadeStarter : MonoBehaviour
{

    public GameObject rightSquare;
    // Start is called before the first frame update
    void Start()
    {
        rightSquare.SetActive(false);
    }

    // checking triger enter 
    private void OnTriggerEnter(Collider other)
    {
        rightSquare.SetActive(true);
        StartCoroutine("WaitTime");
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(5);
        Destroy(rightSquare);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
