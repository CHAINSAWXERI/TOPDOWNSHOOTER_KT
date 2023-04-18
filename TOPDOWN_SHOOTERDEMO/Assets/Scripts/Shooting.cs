using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;

    public void ShootBuller(Vector2 dir)
    {
        Bullet bullet = Instantiate(_bullet);
        bullet.gameObject.transform.position = transform.position;
    }
}

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody2D;
    private Vector2 _dir;
    public void SetMoveTo(Vector2 dir)
    {
        _dir = dir;
    }

    private void Update()
    {
        if (_dir != )
    }
}