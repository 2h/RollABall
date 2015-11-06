using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	
	private Vector3 offset;

	// Use this for initialization
	void Start () {
	
		//To find our offset value betwenn the Camera and the Player
		offset = transform.position - player.transform.position;

	}
	
	// Update is called once per frame
	void LateUpdate () {
		//Add the offset value to the Players current position to reposition the Camera
		//once again relative to the Player
		transform.position = player.transform.position + offset;
	}
}
