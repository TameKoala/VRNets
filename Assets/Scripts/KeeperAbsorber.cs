using UnityEngine;
using System.Collections;

public class KeeperAbsorber : MonoBehaviour {

    public int score;

	// Use this for initialization
	void Start () {
        ScoreKeeper oldKeeper = FindObjectOfType<ScoreKeeper>();
        score = 1;
        if (oldKeeper)
        {
            score = oldKeeper.score;
            DestroyObject(oldKeeper.gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
