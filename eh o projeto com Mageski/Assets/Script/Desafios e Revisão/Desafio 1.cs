using UnityEngine;
public class Desafio1 : MonoBehaviour
{

    [SerializeField] private int Idade;

    [SerializeField] private int[] Idades;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Idade = 28;

        Idades = new int[3] { 18, 19, 70 };



        //Para atribuir valor a um Array, deve-se colocar um número entre os colchetes. Ex: [5] --> Isso indica a quantidade de elementos que terá no Array.

        /*Primeira forma:
        Idades = new int[3];

         Idades[0] = 18;
         Idades[1] = 19;
         Idades[2] = 70;*/

        /*Segunda forma;
        Idades = new int[3]{ 18, 19, 70 };*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}