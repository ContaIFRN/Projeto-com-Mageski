using UnityEngine;

public class SistemaDeVIda : MonoBehaviour

{

    protected int vidaMax;
    private int vidaAtual;

    public int VidaAtual
    {
        get  { return vidaAtual; }
        private set { Mathf.Clamp(value,0,vidaMax); }
    }
    
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
