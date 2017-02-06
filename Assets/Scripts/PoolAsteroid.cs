using UnityEngine;
using System.Collections;

public class PoolAsteroid  
{
	public int ID;
	public Transform trasnformObject;
	public Rigidbody2D rigidobject;


	public PoolAsteroid (int idGo, Transform transformGo, Rigidbody2D rigidbodyGo)
	{
		ID = idGo;
		trasnformObject = transformGo;
		rigidobject = rigidbodyGo;
	}

}
