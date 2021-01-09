using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raiocast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit = new RaycastHit();

        if (!Physics.Raycast(transform.position, transform.forward, out hit, 0.5f))
        {
            print("tocoux");
        }

    }
}
