using UnityEngine;

public class AttackPink : MonoBehaviour
{

    //Zona de variables globales
    private Animator _anim;
    [SerializeField]
    private Collider _colliderAttack;

    private void Awake()
    {
        _anim = GetComponent<Animator>();   
    }
    

    // Update is called once per frame
    void Update()
    {
        InputAttack();
    }
    private void InputAttack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();

        }

    }
    private void Attack()
    {
        _anim.SetTrigger("Attack");
    }
   private void OnEnableCollider()

    {
        //Habilitar collider espada
        _colliderAttack.enabled = true;

    }
    private void OnDisableCollider()

    {
        //Deshabilitar collider espada
        _colliderAttack.enabled = false;

    }

}
