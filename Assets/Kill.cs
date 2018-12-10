using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {
	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Player")) {
			GameObject spawnZone = GameObject.Find("spawn");
			spawnZone.GetComponent<Spawner>().Spawning();
			Destroy(other.gameObject);
		}
	}
}
