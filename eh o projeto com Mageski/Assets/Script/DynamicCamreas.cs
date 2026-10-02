using UnityEngine;

public class DynamicCamreas : MonoBehaviour
{
    [Header("Cameras")]
    [SerializeField] GameObject camB;
    
    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "triggerCam":
                camB.SetActive(true);
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        switch (other.tag)
        {
            case "triggerCam":
                camB.SetActive(false);
                break;
        }
    }
}
