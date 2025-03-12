using UnityEngine;

public class SpinCube : MonoBehaviour
{

    public Vector3 rotateAmount;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(rotateAmount);
    }
}
