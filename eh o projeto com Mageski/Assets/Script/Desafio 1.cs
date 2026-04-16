using UnityEngine;
public class Desafio1 : MonoBehaviour
{

    [SerializeField] private int Idade;

    [SerializeField] private int[] Idades;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Idade = 28;
        Idades = new int[] { 10, 20, 30 };

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}