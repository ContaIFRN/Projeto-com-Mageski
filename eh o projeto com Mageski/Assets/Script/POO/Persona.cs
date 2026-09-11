using UnityEngine;

public class Persona : MonoBehaviour
{
    [SerializeField] protected string nome;
    [SerializeField] protected int vida;
    [SerializeField] protected float velocidade;
    [SerializeField] protected int força;
    [SerializeField] protected int tec;
    [SerializeField] protected int mana;

    protected virtual void Attack()
    {
        Debug.Log("Atacou o galado");
    }

    
}
