using UnityEngine;

public class Testes1 : MonoBehaviour
{

    private int espaçoDeInventario = 10;
    private bool vivo = true;
    private [SerializeField] float DanoDoPersonagem = 10.5f;
    private [SerializeField] float VidaDoPersonagem = 150f;
    private [SerializeField] string nomeDoPersonagem = "Guerreiro";
    public string ArmaDoPersonagem = "NomeDaArma";
    public bool UsaArmadura = true;
    public float ReduçãoDeDanoDaArmadura = 1.5f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float danoDoSlime = 12.5f;
        float vidaDoSlime = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
