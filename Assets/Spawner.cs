using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Cameras;

public class Spawner : MonoBehaviour {

	[SerializeField] private bool spawnPlayer = true;

	[SerializeField] private AbstractTargetFollower cameraSys;

	[SerializeField] private GameObject prefabCreature;

	public void Spawning() {
		GameObject creature = Instantiate(prefabCreature, transform.position, transform.rotation);
		if (spawnPlayer) {
			cameraSys.SetTarget(creature.transform);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
