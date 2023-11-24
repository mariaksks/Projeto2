using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chuva : MonoBehaviour
{
   public ParticleSystem chuva;
   float tempoChuva = 180f;

    void Start()
    {
        // Obtém a referência para o componente ParticleSystem
        chuva = GetComponent<ParticleSystem>();

        // Inicia o sistema de partículas no início (opcional)
        PararChuva();
    }

    void Update()
    {
        // Exemplo: Pressionar a tecla Espaço para alternar entre iniciar e parar o sistema de partículas
        if (chuva.isPlaying)
        {
           Invoke("PararChuva", 10f);
        }
        else
        {
            Invoke("IniciarChuva",5f);
            tempoChuva -= 20f;
        }
     }

    void IniciarChuva()
    {
        // Inicia o sistema de partículas
        chuva.Play();
        InvokeRepeating("PararChuva",40f,40f);
    }

    void PararChuva()
    {
        // Para o sistema de partículas
        chuva.Stop();
    }
}
