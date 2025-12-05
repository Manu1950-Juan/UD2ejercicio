using UnityEngine;

public class DistroyEnemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //zona varibales globales
    private void OnTriggerEnter(Collider InfoAcces)
    {
       if (InfoAcces.CompareTag("AttackPlayer"))
        {
            Destroy(gameObject);
        }
    }

        
}
