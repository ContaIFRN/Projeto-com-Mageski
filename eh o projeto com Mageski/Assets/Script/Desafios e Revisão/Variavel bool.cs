using UnityEngine;

public class Variavelbool : MonoBehaviour
{

    public bool NaEscola = true;
    private int numberOfCoins = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        while (numberOfCoins < 100)
        {
            Debug.Log("Voce esta no nivel 1");
            numberOfCoins++;

           
        }
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
