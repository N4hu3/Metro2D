using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoombieDamage : MonoBehaviour
{
    public int damage;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player"){
            PlayerHealth.instance.TakeDamage(damage);
        }
    }
}
