using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
	private List<Bullet> _bullets;

	public void AddBullet(Bullet bullet)
	{
		if (_bullets != null)
		{
			_bullets.Add(bullet);
		}
	}
}
