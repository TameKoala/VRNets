using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour {

    [Tooltip("Time it takes for ball to destroy itself after instantiation in seconds.")]
    public float lifeTime = 5;

	void Start () {
        Destroy(gameObject, lifeTime);
	}
}
