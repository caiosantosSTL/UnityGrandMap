using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseInicio : MonoBehaviour
{
    public GameObject UIAzul;
    public GameObject UIHUD;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;//pausado
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void iniciarJogo()
    {
        Time.timeScale = 1; //nao pausado
        UIAzul.SetActive(false); //desativa interface inicial
        UIHUD.SetActive(true);

    }
}
