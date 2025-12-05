using UnityEngine;

public class JumpController : MonoBehaviour
{
    [SerializeField] 
    private float _jumpForce;      // Fuerza del salto
    [SerializeField] 
    private float _rayLength;      // Longitud del raycast
    [SerializeField] 
    private LayerMask _groundMask; // Capa del suelo
    [SerializeField]
    private Transform _groundCheck; // Posición desde los pies

    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        JumpInput();
    }

    private void JumpInput()
    {
        // Raycast hacia abajo desde los pies
        if 
            (Physics.Raycast(_groundCheck.position, -transform.up, _rayLength, _groundMask))
        {
            // Si el jugador presiona espacio, salta
            if 
                (Input.GetKeyDown(KeyCode.Space))
            {
                _rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            }
        }

        // Visualizar el raycast en escena
        Debug.DrawRay(_groundCheck.position, -transform.up * _rayLength, Color.red);
    }
}

