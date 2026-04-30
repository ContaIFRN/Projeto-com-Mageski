using UnityEngine;

public class StatusDePersonagem : MonoBehaviour
{

    public string nomeDoPersonagem;
    [SerializeField] private float saudeAtual;
    [SerializeField] private int nivelDificuldade;
    private bool estaEmCombate = false;
    [SerializeField] private float multiplicadorDeDano;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(saudeAtual <= 20 && estaEmCombate == true)
        {
            Debug.Log("Atenção, neguin! Vida crítica em combate");
        }

        if(saudeAtual <= 0)
        {
            Debug.Log("Game over, neguin");
        }

        if(Input.GetKey(KeyCode.D))
        {
            estaEmCombate = true;
            saudeAtual -= multiplicadorDeDano;
        }


    }
}
