using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoPlayer : MonoBehaviour
{
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private GameObject bala;

    void Update()
    {
        if (Input.GetButtonDown("Fire2")){
            //disparar
            Disparar();
        }

    }

    private void Disparar(){
        Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);
    }
}
