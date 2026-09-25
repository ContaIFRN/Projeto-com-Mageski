using UnityEngine;

public class Protagonista : Entidade
{
    protected override void Attack()
    {
        Debug.Log(nome1 + " atacou com a espada da Deusa");
    }

    protected override void Guard()
    {
        Debug.Log(nome1 + " defendeu com a aura divina");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nome1 = "Valkaria";
        tipo = "Deusa guerreira";
        vida1 = 24;
        força1 = 6;
        
        Attack();
        Guard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
