using UnityEngine;

public class Persona : MonoBehaviour
{
    [SerializeField] protected string nome;
    [SerializeField] protected int vida;
    [SerializeField] protected float velocidade;
    [SerializeField] protected int força;
    [SerializeField] protected int tec;
    [SerializeField] private float manaAtual;
    [SerializeField] protected float manaMax;

    public int Vida
    {
        get { return vida;}
        private set { vida = value; }
    }
    
    
    public float ManaAtual
    {
        get { return ManaAtual;} 
        private set { manaAtual =  Mathf.Clamp (value,0,manaMax);}
    }
    

    protected virtual void Attack()
    {
        Debug.Log("Atacou o galado");
    }

    
}
