using UnityEngine;

public class AnimatedReticle : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    
    private void Update()
    {
        transform.Rotate(new Vector3(0, rotationSpeed, 0) * Time.deltaTime);
    }
}
