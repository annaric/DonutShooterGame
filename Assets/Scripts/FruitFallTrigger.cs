using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitFallTrigger : MonoBehaviour
{
    bool hasAlreadyRig = false;
    public GameObject fruits;
    public GameObject tree;
    public GameObject fruitPrefab;

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
        if(other.tag == "Player")
            {
                if (Input.GetKeyDown(KeyCode.F) && !hasAlreadyRig)
                {
                    foreach (Transform child in fruits.transform)
                        child.gameObject.AddComponent<Rigidbody>();
                    hasAlreadyRig = true;  
                }
                //if (Input.GetKeyDown(KeyCode.F) && hasAlreadyRig)
                //{
                    //GameObject newFruits = Instantiate(fruitPrefab, new Vector3(0,0,0), Quaternion.identity);
                    //newFruits.transform.parent = tree.transform;
                    //hasAlreadyRig = false;  
                //}
                
            }

    }

}
