using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float movementSpeed;
    
    private Rigidbody rb;
    private CharacterController controller;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
