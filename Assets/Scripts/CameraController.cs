using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	private Transform _playerTransform;

	private Transform _transformCamera;

	private Camera _cameraMain;

	private float _rightSideCamera;
	private float _leftSideCamera;
	private float _bottomSideCamera;


	public Transform TramsformCamera
	{
		get
		{
			if(_transformCamera == null)
				_transformCamera = gameObject.GetComponent<Transform>();

			return _transformCamera;
		}
	}



	public Camera CameraMain
	{
		get
		{
			if(_cameraMain == null)
				_cameraMain = Camera.main;

			return _cameraMain;
		}
	}



	public float LeftSideCamera
	{
		get
		{
			_leftSideCamera = TramsformCamera.position.x - CameraMain.orthographicSize * CameraMain.aspect;

			return _leftSideCamera;
		}
	}


	public float RightSideCamera
	{
		get
		{
			_rightSideCamera = TramsformCamera.position.x + CameraMain.orthographicSize * CameraMain.aspect;

			return _rightSideCamera;
		}
	}


	public float BottomSideCamera
	{
		get
		{
			_bottomSideCamera = TramsformCamera.position.x + CameraMain.orthographicSize;

			return _bottomSideCamera;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
