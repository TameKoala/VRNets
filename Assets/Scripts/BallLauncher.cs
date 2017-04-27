using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

    public GameObject BallPrefab;
    public float ballForwardSpeed = 10.0f;
    public float ballVerticalSpeed = 5.0f;

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        

        if (Input.GetButtonDown("Tap"))
        {
            Camera camera = GetComponent<Camera>();
            GameObject instance = Instantiate(BallPrefab);
            instance.transform.position = camera.transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = camera.transform.rotation * new Vector3(0,ballVerticalSpeed,ballForwardSpeed);
        }
    }
}
