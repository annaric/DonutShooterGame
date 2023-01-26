using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRigidbodyOnHit : MonoBehaviour
{
    public string targetTag;
    public AudioClip[] audioClips;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            PoliceKillCounter.policeKillCounterInstance.policeKillCounter++;
            playRandomSound(collision.gameObject);
            AddRigidbodyRecursive(collision.gameObject.transform);
        }
    }

    public void playRandomSound(GameObject parent)
    {
        AudioSource audioSource = parent.GetComponent<AudioSource>();
        int randomSoundID = Random.Range(0, audioClips.Length);
        audioSource.PlayOneShot(audioClips[randomSoundID]);
    }

    public void AddRigidbodyRecursive(Transform parent)
    {
        parent.gameObject.AddComponent<Rigidbody>();
        if (parent.gameObject.GetComponent<Animator>() != null)
        {
            parent.gameObject.GetComponent<Animator>().enabled = false;
        }

        for (int i = 0; i < parent.childCount; i++)
        {
            AddRigidbodyRecursive(parent.GetChild(i));
            //Destroy(parent.gameObject);
        }
    }
}