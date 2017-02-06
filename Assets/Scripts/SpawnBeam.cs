using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnBeam : MonoBehaviour {


	List <PoolBeam> _poolBeam;

	private GameObject _beam;
	public GameObject beamBase
	{
		get
		{
			if (_beam == null)
			{
				_beam = Resources.Load<GameObject>("Prefabs/Beam");

				if (_beam == null)
					Debug.LogError("Can not load field");
			}

			return _beam;
		}
	}

	private void Awake()
	{
		_poolBeam = new List<PoolBeam> ();
	}

	public void AddBeam (Vector2 position)
	{
		
		PoolBeam beam = null;

		for (int i = 0; i < _poolBeam.Count; i++)
		{
			if(!_poolBeam[i].transformObject.gameObject.activeInHierarchy)
			{
				beam = _poolBeam [i];
				break;
			}
		}

		if(beam == null)
		{
			//create beam
			GameObject beamGO = Instantiate (beamBase) as GameObject;
			beam = new PoolBeam (beamGO.GetInstanceID(), beamGO);
			_poolBeam.Add (beam);
		}

		beam.transformObject.gameObject.SetActive (true);

		beam.transformObject.position = position;

		StartCoroutine(beam.MoveUp ());
	}

}
