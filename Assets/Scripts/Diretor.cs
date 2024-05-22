using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGameOver;
    private Bird bird;

    private void Start()
    {
        this.bird = GameObject.FindObjectOfType<Bird>();
    }

    public void FinalizarJogo()
    {   
        //habilitar a imagem de Game Over
        this.imagemGameOver.SetActive(true);
        Time.timeScale = 0;

    }

    public void ReiniciarJogo()
    {
        this.imagemGameOver.SetActive(false);
        Time.timeScale = 1;
        this.bird.Reiniciar();
        this.DestruirObstaculos();
    
    }

     private void DestruirObstaculos()
    {
        Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
        foreach(Obstaculo obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
}
