﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdivinhaONumero : MonoBehaviour
{

    [SerializeField] int minimoNoInicio = 1;
    [SerializeField] int maximoNoInicio = 130;


    int minimo; //declaração da variável
    int maximo; //declaração de variável
    int valorAAdivinhar;

    // Start is called before the first frame update
    void Start()
    {
        Iniciar();
    }


    // Update is called once per frame
    void Update()
    {
        //O JOGADOR CARREGOU EM ALGUMA TECLA?
        if (Input.GetKeyDown(KeyCode.UpArrow)) //Sim - Se tiver pressionado; Não - caso contrário
        {
            //Código a executar se o jogador pressionar a tecla para cima

            minimo = valorAAdivinhar;
            CalculaEImprime();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Código a executar se o jogador pressionar a tecla para baixo

            maximo = valorAAdivinhar;
            CalculaEImprime();
            
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            //Código a executar se o jogador pressionar o Enter
            Debug.Log("Viste como eu sou um génio?!");
            Iniciar();
        }
    }


    //MÉTODO OU FUNÇÃO!
    void CalculaEImprime()
    {
        valorAAdivinhar = Random.Range(minimo, maximo);

        Debug.Log("Eu acho que o número em que pensaste é " + valorAAdivinhar);

        Debug.Log("Para responderes");
        Debug.Log("Seta Cima - o número em que pensaste é maior");
        Debug.Log("Seta Baixo - o número em que pensaste é menor");
        Debug.Log("Enter - o número em que pensaste é este!");
    }

    void Iniciar()
    {

        minimo = minimoNoInicio;   //este é o valor minimo do jogo
        maximo = maximoNoInicio; //este é o valor máximo do jogo

        Debug.Log("Olá, vamos jogar um jogo!");
        Debug.Log("Eu vou tentar adivinhar o número em que pensas");
        Debug.Log("Pensa então num número entre " + minimo + " e " + maximo);

        maximo = maximo + 1;

        CalculaEImprime();
    }
}