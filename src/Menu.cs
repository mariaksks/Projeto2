using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   
    public void Jogar()
    {
        SceneManager.LoadScene("Historia");
    }
    public void Avancar()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void Sair()
    {
        Application.Quit();
    }
    public void JogarNovamente()
    {
        SceneManager.LoadScene("Jogo");
    }
}
