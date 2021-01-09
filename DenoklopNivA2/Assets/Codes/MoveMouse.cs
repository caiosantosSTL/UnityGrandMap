using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveMouse : MonoBehaviour
{
    NavMeshAgent agent;
    private float alt = 10f;
    bool chao = true;
    private Rigidbody rbody;



    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); // pegar componente

        rbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //0 butao esquerdo
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//para clicar na camera
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                agent.SetDestination(hit.point);
                print("Cordenada "+ray);

            }
            
        }

        if (Input.GetKeyDown(KeyCode.Space) && chao)
        {
            print("jump");// com navmesh pulo nao funciona
            rbody.AddForce(new Vector3(0, alt, 0), ForceMode.Impulse);
            
        }

    }


    //fora do metodo upadte
    void OnCollisionStay(Collision collision)
    {
        chao = true;
    }
    void OnCollisionExit(Collision collision)
    {
        chao = false;
    }
}
