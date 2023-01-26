using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegrowFruits : MonoBehaviour
{

    public GameObject tree;
    public GameObject treePrefab;
    public float Timer = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine( RenderNewPolice() );
    }


    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            GameObject treeClone = Instantiate(treePrefab, tree.transform.position, tree.transform.rotation) as GameObject;
            Destroy(tree);
            Timer = 20.0f;
        }
    }

}
