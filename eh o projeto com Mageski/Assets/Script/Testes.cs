using UnityEngine;

public class Testes : MonoBehaviour
{
    //Variável = Algo que varia
    //Constante = Algo que não varia. Se escreve "const" antes do tipo, e o valor deve ser atribuído no momento da declaração, ou seja, não pode ser alterado depois.
    //Variável privada = Só pode ser acessada dentro da classe onde foi declarada e não pode ser acessado no inspector do unity. Ex: private int Vida;
    //Variável pública = Pode ser acessada por outras classes e aparece no inspector do unity. Ex: public int Vida;
    //[SerializeField] serve para mostrar a variável privada no inspetor do Unity
    //Variavél local é um tipo de variável privada somente em um método específico, logo, pode-se repetir o nome fora do método.
    //Arrays = Tipo de váriavel que armazena vários valores DO MESMO TIPO (int, flotat, string, etc). Ex: private int "[]" Stamina 


    //Variável Simples (apenas um valor)
    private int A;
    private int B = 10;
    public int C = 15;

    //Variáveis Array (mais de um valor)
    [SerializeField] private string[] Inimigos;


    private float Velocidade = 4.5f;
    private int EspaçoDeInventario = 10;
    private bool Vivo = true;
    [SerializeField] private float DanoDoPersonagem = 10.5f;
    [SerializeField] private float VidaDoPersonagem = 150f;
    [SerializeField] private string nomeDoPersonagem = "Guerreiro";
    public string ArmaDoPersonagem = "NomeDaArma";
    public bool UsaArmadura = true;
    public float ReducaoDeDanoDaArmadura = 1.5f;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Variável local (só existe dentro do método onde foi declarada)

        float danoDoSlime = 12.5f;
        float vidaDoSlime = 100f;
    }
    // Update is called once per frame
    void Update()
    {


    }

}

