//
//Filename: MouseCameraControl.cs
//

using UnityEngine;

[AddComponentMenu("Camera-Control/Mouse")]
public class cameraControllerKeyboardScript : MonoBehaviour
{
	public GameObject character;
	private float speed = 80.0f;

	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow)){
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow)){
			transform.position += Vector3.left* speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow)){
			transform.position += Vector3.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.UpArrow)){
			transform.position += Vector3.back* speed * Time.deltaTime;
		}


	}

}