using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    private CharacterController controller;
    private Vector3 direction;


    [Header("Player Settings")]
    [SerializeField] private float movementSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float  horizontal = Input.GetAxis("Horizontal"); //Estou pegoando o input em x // o "." é para acessar algo dentro de uma classe, nesse caso o "Horizontal" dentro do "Input"
        float vertical = Input.GetAxis("Verrtical"); //Estou pegoando o input em y  

       direction = new Vector3(horizontal, 0f, vertical).normalized; //o new Vector3 é para criar um vetor, nesse caso o "direction" que tem os valores de "horizontal" e "vertical".
       //normalized é para normalizar o vetor, ou seja, deixar ele com o mesmo tamanho, independente da direção que ele esteja apontando. 
       


    }
}
