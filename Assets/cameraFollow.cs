using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

	//Atributos de la clase
	public GameObject follow;
	public Vector2 minCamPosition, maxCamPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float posX = follow.transform.position.x;
		float posY = follow.transform.position.y;

    Debug.Log("x: "+posX);
		Debug.Log("x: "+posY);
		transform.position = new Vector3(
			Mathf.Clamp(posX, minCamPosition.x, maxCamPosition.x),
      Mathf.Clamp(posY, minCamPosition.y, maxCamPosition.y), 
			transform.position.z
		);
	}
}
