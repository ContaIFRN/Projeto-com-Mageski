using UnityEngine;
using UnityEngine.UIElements;

public class Grass : MonoBehaviour
{

    [SerializeField] private ParticleSystem fxHit;
    private bool isCut;    
    
    public void GetHit(int amount)
    {
        if (!isCut)
        {
            fxHit.Emit(10);
            isCut = true;
        }
        transform.localScale = new Vector3(1f, 1f, 1f);
    }

}
