using UnityEngine;

public class ifeelse : MonoBehaviour
{

    //if = se. Serve para criar uma condição, ou seja, se algo for verdadeiro, faça algo. Ex: if (VidaDoPersonagem <= 0) {Morreu = true;}
    //else = senão. Serve para criar uma condição alternativa, ou seja, se algo não for verdadeiro, faça algo. Ex: else {Morreu = false;}

    public bool estouComFome = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (estouComFome == true)
        {
            Debug.Log("Quero comer!");
        }
        else
        {
            Debug.Log("Não quero comer.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
