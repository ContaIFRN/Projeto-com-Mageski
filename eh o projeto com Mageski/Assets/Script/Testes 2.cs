using UnityEngine;

public class Testes2 : MonoBehaviour
{

    private string Nome = "Antonio";
    private int A = 1;
    private int B = 100;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //Incremento de Variáveis: 
        /*A++; --> Somente 1 unidade.
          A += 10;    
          A = A + 15;  
        Adiciona 1 a variável.*/

        //Decremento de Variáveis:
        /* A--; --> Subtrai somente 1 unidade.
          A -= 10;    
          A = A - 15;*/

        //Multiplicação de Variáveis:
        /*A**; --> Multiplica por ele mesmo. Ex: 2** = 2*2 = 4.
          A *= 10;    
          A = A * 15; */

        //Divisão de Variáveis:
        /*A /= 10;    
          A = A / 15; */


        for (int i= 100; i >B; i--)
        {
            Debug.Log(i);
        }
            



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
