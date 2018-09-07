using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	private BulletManager _bulletManager;

	// Use this for initialization
	void Start () {
		_bulletManager = gameObject.AddComponent<BulletManager>();
	}
	
}
