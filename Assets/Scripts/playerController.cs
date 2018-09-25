using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	//Atributos de la clase
	public float maxSpeed = 10f;
	public float speed = 20f;
	private Rigidbody2D rbPlayer;
	private Animator animPlayer;

	// Use this for initialization
	void Start () {
		rbPlayer = GetComponent<Rigidbody2D>();
		animPlayer = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		float h = Input.GetAxis("Horizontal");

		rbPlayer.AddForce(Vector2.right*speed*h);

	}
}
