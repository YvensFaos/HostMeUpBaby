using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveCube : MonoBehaviour
{
    private Rigidbody _body;

    [SerializeField]
    private float Force;
    [SerializeField]
    private float Turn;
    
    private void Awake()
    {
        _body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _body.AddForce(transform.forward * Force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _body.AddForce(-transform.forward * Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(transform.up, -Turn);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(transform.up, Turn);
        }
    }
}
