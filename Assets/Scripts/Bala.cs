using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float velocidad;
    public int daño;

    void Start()
    {
        daño = 1;
    }

    void Update()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Obtén el componente ZoombieHealth del enemigo con el que colisionaste.
            ZoombieHealth enemyHealth = other.GetComponent<ZoombieHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(daño);
            }
            Destroy(gameObject);
        }
        else if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }

}
