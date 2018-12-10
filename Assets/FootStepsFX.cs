using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityScript.Steps;

public class FootStepsFX : MonoBehaviour {

	[SerializeField] private AudioClip[] sfx;
	[SerializeField] private ParticleSystem[] vfx;

	private AudioSource a;

	private TerrainTextures terrain;	
	// Use this for initialization
	void Start () {
		a = GetComponent<AudioSource>();
		terrain = GetComponent<TerrainTextures>();
	}

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.name.Length < 3) {
			int num = int.Parse(other.gameObject.name);
			a.PlayOneShot(sfx[num]);
			vfx[num].Emit(10);	// Emit 10 particles
		}
		else {	// assume that players walk on a terrain
			int val = terrain.surfaceIndex;
			a.PlayOneShot(sfx[val]);
			vfx[val].Emit(10);
		}
//		if (other.gameObject.name == "rock") {
//			a.PlayOneShot(sfx[0]);	// 0 is the rock music
//		}
//		else if (other.gameObject.name == "sand") {
//			a.PlayOneShot(sfx[1]);
//		}
//		else if (other.gameObject.name == "grass") {
//			a.PlayOneShot(sfx[2]);
//		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
