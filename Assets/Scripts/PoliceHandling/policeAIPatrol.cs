using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class policeAIPatrol : MonoBehaviour
{
    GameObject player;

    NavMeshAgent agent;

    GameObject agentObject;

    [SerializeField] LayerMask groundLayer, playerLayer;

    public AudioClip[] audioClips;

    //patrol
    Vector3 destPoint;
    bool walkpointSet;
    [SerializeField] float walkRange;
    [SerializeField] float sightRange, touchRange;
    bool playerInSight;
    bool lifeTaken = false;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        playerInSight = Physics.CheckSphere(transform.position, sightRange, playerLayer);


        if(!playerInSight)
        {
            Patrol();
            lifeTaken = false;
        }

        if(playerInSight) Chase();
    }

    void Chase()
    {
        agent.SetDestination(player.transform.position);
        if (Physics.CheckSphere(transform.position, touchRange, playerLayer) && !lifeTaken)
        {
            playRandomSound(player);
            playRandomSound(player);
            LifeCounter.lifeCounterInstance.lifeCounter--;
            lifeTaken = true;
        }
    }

    void Patrol()
    {
        if(!walkpointSet) SearchForDest();
        if(walkpointSet) agent.SetDestination(destPoint);
        if(Vector3.Distance(transform.position, destPoint) < 10) walkpointSet = false;
    }

    void SearchForDest()
    {
        float z = Random.Range(-walkRange, walkRange);
        float x = Random.Range(-walkRange, walkRange);

        destPoint = new Vector3(transform.position.x + x, transform.position.y, transform.position.z + z);

        if(Physics.Raycast(destPoint, Vector3.down, groundLayer))
        {
            walkpointSet = true;
        }
    }

    public void playRandomSound(GameObject parent)
    {
        AudioSource audioSource = parent.GetComponent<AudioSource>();
        int randomSoundID = Random.Range(0, audioClips.Length);
        audioSource.PlayOneShot(audioClips[randomSoundID]);
    }
}
