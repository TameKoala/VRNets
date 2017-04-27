using UnityEngine;
using System.Collections;

public class SecondaryTrigger : MonoBehaviour {

    Collider expectedcollider;
    public int scoreAmount = 1;
    
    public void ExpectCollider(Collider collider)
    {
        expectedcollider = collider;
    }
    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider == expectedcollider)
        {
            ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
            scoreKeeper.ScoreIncrement(scoreAmount);

            AudioSource score = GetComponent<AudioSource>();
            score.Play();
        }
    }
}
