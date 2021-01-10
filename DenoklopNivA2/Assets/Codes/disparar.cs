using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparar : MonoBehaviour
{
    public Transform bala;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Instantiate(bala, transform.position, transform.rotation);

        }
        
    }

    private void OnDestroy()
    {
        //Destroy(bala, 2f);

    }
}
