using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camsegue : MonoBehaviour
{
    //camera seguir objeto vazio 
    GameObject pontoRef;

    // Start is called before the first frame update
    void Start()
    {
        pontoRef = GameObject.Find("target");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pontoRef.transform.position;
        transform.rotation = pontoRef.transform.rotation;
    }
}
