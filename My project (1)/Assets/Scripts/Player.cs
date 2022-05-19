using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public Projectile Bulletprefab;

    public float speed = 5.0f;

    private bool _BulletActive;


    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * this.speed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            this.transform.position += Vector3.right * this.speed * Time.deltaTime;
        {




        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (!_BulletActive)
        {
            Projectile projectile = Instantiate(this.Bulletprefab, this.transform.position, Quaternion.identity);
            projectile.destroyed += BulletDestroyed;

            _BulletActive = true;
        }
        
    }


    private void BulletDestroyed()
    {
        _BulletActive = false;
    }
}
