using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Movecontroller: MonoBehaviour
{
    [SerializeField]
    private float _speed;   // Velocidad de movimiento
    [SerializeField]
    private float _turnSpeed;   // Velocidad de giro
    private float _horizontal;
    private float _vertical;
    private Animator _anim;

    private void Awake()
    {
        //variable de animacion
        _anim = GetComponent<Animator>();
    }

    void Update()
    {
        InputsPlayer();
        Move();
        Turn();
        Animating();

    }
    private void InputsPlayer()

    {
        //Teclas A y D y las flechas <>
        _horizontal = Input.GetAxis("Horizontal");
        //Teclas W y S y las flechas 
        _vertical = Input.GetAxis("Vertical");


    }


    private void Move()
    {
        transform.Translate(Vector3.forward * _speed * _vertical * Time.deltaTime);

    }
    private void Turn() 
    {
        transform.Rotate(Vector3.up * _horizontal* _turnSpeed * Time.deltaTime);

    }
    private void Animating()
    {
        if (_vertical != 0) 
        //el personaje se esta moviendo
        {
            _anim.SetBool("isMoving",true);   

        }

        else
        {
            _anim.SetBool("isMoving",false);    
        }
    }    

}