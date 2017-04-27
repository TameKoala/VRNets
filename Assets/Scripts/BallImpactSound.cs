using UnityEngine;
using System.Collections;

public class BallImpactSound : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }
}
