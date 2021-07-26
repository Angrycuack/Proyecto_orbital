using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    private CentralSphereMovement _player;

    private void Start()
    {
        _player = GameObject.Find("Player").GetComponent<CentralSphereMovement>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
            GameController.instance.AddOrbit(false);
        }
        if (collision.gameObject.CompareTag("MultiplePU"))
        {
            _player.PowerUp();
            Destroy(collision.gameObject);
        }
    }
}
