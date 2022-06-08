using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int pontuacaoDoJogador1;

    public int pontuacaoDoJogador2;

    public Text textoDePontuacao;

    public AudioSource somDoGol;
    void Start()
    {
        pontuacaoDoJogador1 = 0;
        pontuacaoDoJogador2 = 0;
        textoDePontuacao.text = pontuacaoDoJogador1 + " X " + pontuacaoDoJogador2;
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            reiniciarPartida();
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SairDoJogo();
        }
    }

    public void AumentarPontuacaoDoJogador1()
    {
        pontuacaoDoJogador1 += 1;
        atualizarTextoDePontuacao();
    }

    public void AumentarPontuacaoDoJogador2()
    {
        pontuacaoDoJogador2 += 1;
        atualizarTextoDePontuacao();
    }

    public void atualizarTextoDePontuacao()
    {
        textoDePontuacao.text = pontuacaoDoJogador1 + " X " + pontuacaoDoJogador2;
        somDoGol.Play();
    }

    private void reiniciarPartida()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void SairDoJogo()
    {
        Application.Quit();
    }
}
