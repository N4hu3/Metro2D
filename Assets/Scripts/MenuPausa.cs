using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Este namespace es correcto

public class MenuPausa : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;
   
   void Start(){
      menuPausa.SetActive(false);
   }

    public void Pausa()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }
   
    public void Reiniciar()
    {
        Time.timeScale = 1f;
        // Corregido: SceneManager en lugar de SceneManagement
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Cerrar()
    {
        Debug.Log("Aplicación cerrada"); // Opcional: añadir log para debug
        Application.Quit();
    }
}
