using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        float RotationSpeed = 2;
        float MouseX = Input.GetAxis("Mouse X") * RotationSpeed;
        float MouseY = Input.GetAxis("Mouse Y") * RotationSpeed;
        transform.localRotation = Quaternion.Euler(0, MouseX, 0) * transform.localRotation;
        Camera camera = GetComponentInChildren<Camera>();
        camera.transform.localRotation = Quaternion.Euler(-MouseY, 0, 0) * camera.transform.localRotation;
    }
}
