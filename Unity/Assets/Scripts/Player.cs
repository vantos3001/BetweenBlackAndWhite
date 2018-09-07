using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Player : MonoBehaviour {

	[SerializeField]
	private GameObject _player;

	private Transform _target;
	private Weapon _weapon;
	
	[SerializeField]
	private float _speed;
	
	private int _health;
	private int _damage;
	// Use this for initialization
	void Start () {
		if (_player != null)
		{
			_target = _player.GetComponent<Transform>();
		}
		else
		{
			Debug.LogError("Player is null");
		}
		
		
	}
	
	// Update is called once per frame
	void Update () {
		Move();
	}
	
	private void DealDamage(){
	}
		
	private void Move(){
		if (Input.GetKey(KeyCode.A)){
			_target.position -= _speed * new Vector3(1, 0, 0);
		}
		if (Input.GetKey(KeyCode.D)){
			_target.position += _speed * new Vector3(1, 0, 0);
		}
		
		if (Input.GetKey(KeyCode.W)){
			_target.position += _speed * new Vector3(0, 1, 0);
		}
		
		if (Input.GetKey(KeyCode.S)){
			_target.position -= _speed * new Vector3(0, 1, 0);
		}
	}
	
}
