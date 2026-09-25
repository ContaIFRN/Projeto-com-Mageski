using UnityEngine;

public class Inimigo : Entidade
{
    protected override void Attack()
    {
        Debug.Log(nome1 + " atacou com um tacape muito pesado");
    }

    protected override void Guard()
    {
        Debug.Log(nome1 + " defendeu sem medo com uma cabeçada");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nome1 = "Sherk";
        tipo = "Orc";
        vida1 = 25;
        força1 = 5;

        Attack();
        Guard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
