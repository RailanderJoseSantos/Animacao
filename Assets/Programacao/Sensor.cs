using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour {

    public Animator animator;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider outro)
    {
        animator.SetBool("entrou", true);
    }
    private void OnTriggerExit(Collider outro)
    {
        animator.SetBool("entrou", false);
    }
}
