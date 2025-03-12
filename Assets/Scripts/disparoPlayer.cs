using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoPlayer : MonoBehaviour
{
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private GameObject bala;

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            //disparar
            Disparar();
        }

    }

    private void Disparar()
    {
        GameObject newBala = Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);
        // Si el jugador está mirando a la izquierda (localScale.x negativo), rota la bala 180° en Y
        if (transform.localScale.x < 0)
        {
            newBala.transform.Rotate(0, 180, 0);
        }
    }

}
