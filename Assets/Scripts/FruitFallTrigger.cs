using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitFallTrigger : MonoBehaviour
{
    bool hasAlreadyRig = false;
    public GameObject fruits;
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
        if(other.tag == "Player" && !hasAlreadyRig)
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    foreach (Transform child in fruits.transform)
                        child.gameObject.AddComponent<Rigidbody>();
                    hasAlreadyRig = true;  
                }
                
            }

    }

}
