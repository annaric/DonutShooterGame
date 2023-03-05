using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRigidbodyOnHit : MonoBehaviour
{
    public string targetTag;
    public AudioClip[] audioClips;
    public GameObject projectile;

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            PoliceKillCounter.policeKillCounterInstance.policeKillCounter++;
            playRandomSound(projectile);
            AddRigidbodyRecursive(collision.gameObject.transform.parent.transform);
        }
    }

    public void playRandomSound(GameObject obj)
    {
        AudioSource audioSource = obj.GetComponent<AudioSource>();
        int randomSoundID = Random.Range(0, audioClips.Length);
        audioSource.PlayOneShot(audioClips[randomSoundID]);
    }

    public void AddRigidbodyRecursive(Transform parent)
    {
        
        if (parent.gameObject.GetComponent<Animator>() != null)
        {
            parent.gameObject.GetComponent<Animator>().enabled = false;
        }

        for (int i = 0; i < parent.childCount; i++)
        {
            AddRigidbodyRecursive(parent.GetChild(i));
            //parent.gameObject.AddComponent<Rigidbody>();
            parent.gameObject.SetActive(false);
        }
    }
}