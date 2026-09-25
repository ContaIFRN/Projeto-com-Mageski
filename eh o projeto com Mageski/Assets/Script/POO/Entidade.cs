using UnityEngine;

public class Entidade : MonoBehaviour
{

    protected string nome1;
    protected string tipo;
    protected int vida1;
    protected int força1;

    protected virtual void Attack()
    {
        Debug.Log(nome1 + "atacou");
    }

    protected virtual void Guard()
    {
        Debug.Log(nome1 + "defendeu");
    }
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
