using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebala : MonoBehaviour
{
    private float sped = 12f;
    public ParticleSystem boom;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        if (sped != 0)
        {
            transform.position += transform.forward * (sped * Time.deltaTime);
            
        }
        else
        {
            print("fara veloco");
        }

        Destroy(gameObject, 1f);

    }


    private void OnDestroy()
    {
        
        Instantiate(boom, transform.position, Quaternion.identity);

    }


}
