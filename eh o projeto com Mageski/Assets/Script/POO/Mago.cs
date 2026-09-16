using System;
using UnityEngine;

public class Mago : Persona
{
   

    private void Start()
    {
        nome = "Dumbledore";
        vida = 12;
        velocidade = 3f;
        força = 8;
        tec = 1;
        
        
        Attack();
    }
    
    protected override void Attack()
         {
             Debug.Log("Atacou o galado com a bola de fogo");
         }
}
