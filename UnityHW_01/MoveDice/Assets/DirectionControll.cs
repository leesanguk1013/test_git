using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionControll : MonoBehaviour
{

    public int DirectionNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    void OnTriggerStay(Collider other)
    {
        

        if (other.gameObject.tag == "Player")
        {
            Move.Direction_switcher = DirectionNum;

        }
    }
    
}
