	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class BasicMovement : MonoBehaviour {
		Rigidbody myBody;
		public float speed;

		// Use this for initialization
		void Start () {
			myBody = GetComponent<Rigidbody>();
		}

		// Update is called once per frame
		void Update () {
			if (Input.GetKey(KeyCode.W)) {
			myBody.velocity=(Vector3.forward*speed);
				Debug.Log("pressed W key");

			}
			if (Input.GetKey(KeyCode.S)) {
				myBody.velocity=(Vector3.back*speed);
				Debug.Log("pressed S key");
			}

			if (Input.GetKey(KeyCode.A)) {
				myBody.velocity=(Vector3.left*speed);
				Debug.Log("pressed A key");
			}

			if (Input.GetKey(KeyCode.D)) {
				myBody.velocity=(Vector3.right*speed);
				Debug.Log("pressed D key");
			}
		}
	}

