using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    public GameObject fruit;
    bool hasAlreadyItem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerStay(Collider other)
    {
        if(other.tag == "PickableItem"  && !hasAlreadyItem)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    //other.transform.SetParent(this);
                }
                
            }

    }
}
