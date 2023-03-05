using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class renderPolice : MonoBehaviour
{

    public GameObject police;
    public Transform policeStation;
    public float Timer = 5.0f;
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
            GameObject policeClone = Instantiate(police, policeStation.position, policeStation.rotation) as GameObject;
            Timer = 5.0f;
        }
    }

}
