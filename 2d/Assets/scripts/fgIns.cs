using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fgIns : MonoBehaviour
{
    public GameObject f;
    public GameObject genPnt1;
    private Vector3 fWidth;

    private void Start()
    {
        fWidth = f.GetComponent<Renderer>().bounds.size;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < genPnt1.transform.position.x)
        {
            transform.position = new Vector3(transform.position.x + fWidth.x, transform.position.y, transform.position.z);
            Instantiate(f, transform.position, transform.rotation);

        }  // Debug.Log("dgfdhg");
    }

}
