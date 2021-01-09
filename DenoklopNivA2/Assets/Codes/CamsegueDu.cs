using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamsegueDu : MonoBehaviour
{
    public Transform alvoCam;
    public float sSped = 10f;
    public Vector3 dist;
    public Transform verAlvo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dPos = alvoCam.position + dist;
        Vector3 spos = Vector3.Lerp(transform.position, dPos, sSped*Time.deltaTime);
        transform.position = spos;
        transform.LookAt(verAlvo.position);
    }
}
