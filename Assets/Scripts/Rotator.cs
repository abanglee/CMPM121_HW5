using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public GameObject pickupEffect;


	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(90, 180, 90) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            Instantiate(pickupEffect, transform.position, transform.rotation);
        }
        
    }
}
