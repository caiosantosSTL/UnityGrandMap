using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour {

    public float move_vel, giro_vel, alt, alt2;
    //bool chao = true;
    bool piso;

    private Transform tsf;
    private Rigidbody rbody;

    // Use this for initialization
    void Start () {
        tsf = GetComponent<Transform>();
        rbody = GetComponent<Rigidbody>();

        

    }
	
	// Update is called once per frame
	void Update () {

        RaycastHit hit = new RaycastHit();


        if (Physics.Raycast(transform.position, transform.forward, out hit, 0.3f))
        {

            if (Input.GetKey(KeyCode.W))
            {
                //tsf.Translate(new Vector3(move_vel, 0, 0) * Time.deltaTime);//frente
                tsf.Translate(new Vector3(0, 0, -move_vel) * Time.deltaTime);//frente
            }
            //print("tocoux");
        }




        if (Physics.Raycast(transform.position, -transform.forward, out hit, 0.3f))
        {
            if (Input.GetKey(KeyCode.S))
            {
                //tsf.Translate(new Vector3(move_vel, 0, 0) * Time.deltaTime);//frente
                tsf.Translate(new Vector3(0, 0, move_vel) * Time.deltaTime);//tras
            }
            //print("tocoux");
        }





        //mover
        if (Input.GetKey(KeyCode.W))
        {
            //tsf.Translate(new Vector3(-move_vel, 0, 0) * Time.deltaTime);//frente
            tsf.Translate(new Vector3(0, 0, move_vel) * Time.deltaTime);//frente
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            //tsf.Translate(new Vector3(move_vel, 0, 0) * Time.deltaTime);//tras
            tsf.Translate(new Vector3(0, 0, -move_vel) * Time.deltaTime);//tras
            
        }




        //giro -y+
        if (Input.GetKey(KeyCode.D))
        {
            tsf.transform.Rotate(0, giro_vel * Time.deltaTime, 0);//dir
        }
        if (Input.GetKey(KeyCode.A))
        {
            tsf.transform.Rotate(0, -giro_vel * Time.deltaTime, 0);//esq
        }

        //lado
        if (Input.GetKey(KeyCode.E))
        {
            tsf.Translate(new Vector3(0, 0, move_vel) * Time.deltaTime);//gesq
        }
        if (Input.GetKey(KeyCode.Q))
        {
            tsf.Translate(new Vector3(0, 0, -move_vel) * Time.deltaTime);//gesq
        }

        // indicador de estar no chao ao nao
        if (Physics.Raycast(transform.position, -transform.up, out hit, 0.5f))
        {
             piso = true;
            //print("chao");
        }
        else
        {
            piso = false;
            //print("nao esta no chao");
        }

            //pulo +y
            if (Input.GetKeyDown(KeyCode.Space) && piso)
        {
            rbody.AddForce(new Vector3(0, alt, 0), ForceMode.Impulse);
            

        }



    }

}
