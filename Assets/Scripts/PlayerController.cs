using UnityEngine;
using System.Collections;
public class Boundary
{
	public float xMin, xMax, yMin, yMax;
}


public class PlayerController : MonoBehaviour {

	public int speed = 2;
	private SpawnBeam _spawn;
	private Transform _transform;
	public Boundary boundary;


	void Start()
	{
		_transform = transform;
		_spawn = GameObject.FindObjectOfType<SpawnBeam> ();
	}

	void Update ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");


		_transform.position = new Vector2 (_transform.position.x + moveHorizontal, _transform.position.y);


		if(Input.GetMouseButtonDown(0))
		{
			_spawn.AddBeam(_transform.position);
		}
	
		

	
		
	}

}
