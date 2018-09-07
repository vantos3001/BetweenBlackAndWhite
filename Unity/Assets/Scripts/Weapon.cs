using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	private WeaponState _state;
	
	public Weapon(WeaponState weaponState = WeaponState.Default)
	{
		_state = weaponState;
	}

	public void Shoot()
	{
		
	}

}

public enum WeaponState
{
	Default,
}
