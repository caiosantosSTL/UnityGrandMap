using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    private static int score;
    public Text scoreT;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreT.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "mano")
        {
            Destroy(gameObject);
            score += 1;
            scoreT.text = "" + score.ToString();
        }
    }


}
