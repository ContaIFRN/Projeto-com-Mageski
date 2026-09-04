using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{

    //Metodo = Uma fun��o que determina o comportamento de um objeto
    //Classe = Um molde para criar objetos, ela define as propriedades e comportamentos que os objetos criados a partir dela ter�o.
    //Fun��o = Um bloco de c�digo que realiza uma tarefa espec�fica, ela pode ser chamada para executar essa tarefa sempre que necess�rio.

    private Rigidbody rb;
    private CharacterController controller;
    private Vector3 direction;
    private Animator animator;
    private bool iWalk;
    
    //Area dedicada para as cameras 
    [Header("Cameras")]
    
    
    //Area dedicada para as configuracoes do player
    [Header("Player Settings")]
    [SerializeField] private float movementSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>(); //GetComponent � um m�todo que serve para pegar um componente que esteja anexado ao mesmo GameObject que o script
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        float  horizontal = Input.GetAxis("Horizontal"); //Estou pegoando o input em x // o "." � para acessar algo dentro de uma classe, nesse caso o "Horizontal" dentro do "Input"
        float vertical = Input.GetAxis("Vertical"); //Estou pegoando o input em y  
        //GetAxis � um metodo do Input que serve para pegar o input do jogador, ele recebe uma string que representa o nome do eixo que queremos pegar, nesse caso "Horizontal" e "Vertical".

        if(Input.GetButtonDown("Fire1"))
        {
            animator.SetTrigger("attack"); //SetTrigger � um m�todo do Animator que serve para ativar um gatilho do Animator, nesse caso o "iAttack" que � um gatilho do tipo trigger.
        }


        direction = new Vector3(horizontal, 0f, vertical).normalized; //o new Vector3 � para criar um vetor, nesse caso o "direction" que tem os valores de "horizontal" e "vertical".
        //normalized � para normalizar o vetor, ou seja, deixar ele com o mesmo tamanho, independente da dire��o que ele esteja apontando. 

        

        if (direction.magnitude > 0.1f) //0.1f para identificar mais facilmente se o jogador quer ou n�o se mover. Se passar de 0.1f, o jogador quer se mover, se for menor, ele n�o quer se mover.
        {
           float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg; //Mathf.Atan2 eh uma biblioteca matematica que serve para fazer calculos matematicos
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f); //targetAngle no y pois � a rota��o do jogador em torno do eixo y e somente nele.
            
            iWalk = true;            
        }
        else
        {
            iWalk = false;  
        }

        animator.SetBool("iWalk", iWalk); //SetBool � um m�todo do Animator que serve para definir o valor de um par�metro do Animator, nesse caso o "iWalk" que � um par�metro do tipo bool.
        controller.Move(direction * movementSpeed * Time.deltaTime); //Move � um m�todo do CharacterController que serve para mover o personagem, ele recebe um vetor de dire��o,
                                                                     //a velocidade e o tempo entre os frames (Time.deltaTime) para garantir que o movimento seja suave e consistente,
                                                                     //independente da taxa de quadros do jogo.












    }
}
