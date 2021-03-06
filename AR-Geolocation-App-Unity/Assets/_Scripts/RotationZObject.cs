using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]

public class RotationZObject : MonoBehaviour
{
	public bool Voice = false;
	public AudioSource Voiceover;

	#region ROTATE
	private float _sensitivity = 1f;
	private Vector3 _mouseReference;
	private Vector3 _mouseOffset;
	private Vector3 _rotation = Vector3.zero;
	private bool _isRotating;


	#endregion

	void Update()
	{
		if (_isRotating)
		{
			// offset
			_mouseOffset = (Input.mousePosition - _mouseReference);

			_rotation.z = -(_mouseOffset.x + _mouseOffset.y) * _sensitivity;

			
			// rotate
			gameObject.transform.Rotate(_rotation);

			// store new mouse position
			_mouseReference = Input.mousePosition;

			
		}

		//transform.Rotate(new Vector3(0f, 0f, 100f) * Time.deltaTime);
	}

	void OnMouseDown()
	{
		// rotating flag
		_isRotating = true;

		// store mouse position
		_mouseReference = Input.mousePosition;
	}

	void OnMouseUp()
	{
		// rotating flag
		_isRotating = false;
	}





}

