using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoDeVida : MonoBehaviour
{
   [SerializeField] private float tiempoDeVida;
    void Start()
    {
        Destroy(gameObject, tiempoDeVida);
    }
}
