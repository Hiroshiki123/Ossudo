using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_inimigo : MonoBehaviour
{
    public inimigo[] ini= new inimigo[0];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                    
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            ini[0].enabled = true;
            ini[1].enabled = true;
            ini[2].enabled = true;
            ini[3].enabled = true;
            ini[4].enabled = true;
            ini[5].enabled = true;
            ini[6].enabled = true;
            ini[7].enabled = true;
        }
    }
}
