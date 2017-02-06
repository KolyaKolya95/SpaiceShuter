using UnityEngine;
using System.Collections;




public class PoolBeam  {

	private float _speed = 5f;

	public int ID;
	public Transform transformObject;


	public PoolBeam(int id, GameObject Beam)
	{
		ID = id;
		transformObject = Beam.transform;
	}

	public IEnumerator MoveUp()
	{
		do 
		{
			transformObject.position = new Vector2(transformObject.position.x, transformObject.position.y + Time.deltaTime * _speed);
			yield return new WaitForEndOfFrame();
		} while(transformObject.position.y <= Camera.main.orthographicSize);

		transformObject.gameObject.SetActive (false);
	}
}
