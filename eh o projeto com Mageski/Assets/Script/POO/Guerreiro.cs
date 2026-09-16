using UnityEngine;

public class Guerreiro :Persona
{

    private void Start()
    {
        nome = "Val";
        vida = 30;
        velocidade = 2.5f;
        força = 16;
        tec = 3;
        
        
        Attack();
        
    }

    protected override void Attack()
    {
        base.Attack();
        Debug.Log("Atacou o galado com a espada");
    }

}
