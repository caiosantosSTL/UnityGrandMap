using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tocarOBG : MonoBehaviour
{
    private void OnMouseDown()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.black;

        //Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
