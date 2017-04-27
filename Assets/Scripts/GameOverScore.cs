using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour {

    Text text;
    KeeperAbsorber keeperAbsorber;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        keeperAbsorber = FindObjectOfType<KeeperAbsorber>();
    }
	
	// Update is called once per frame
	void Update () {
        text.text = "Score: " + keeperAbsorber.score;
    }
}
