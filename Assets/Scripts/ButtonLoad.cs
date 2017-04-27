using UnityEngine;
using System.Collections;

public class ButtonLoad : MonoBehaviour {

    public float timeUntilButton = 0.5f;
    public GameObject ButtonPrefab;
    public GameObject Canvas;
    public GameObject buttonlocation;
    bool button = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timeUntilButton -= Time.deltaTime;

        if (timeUntilButton < 0 & button == false)
        {
            GameObject instance = Instantiate(ButtonPrefab);
            instance.transform.parent = Canvas.transform;
            instance.transform.position = buttonlocation.transform.position;
            instance.transform.localScale = new Vector3(1, 1, 1);
            button = true;
        }
    }
}
