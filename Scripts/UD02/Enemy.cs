using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider infoAcces)
    {
        if (infoAcces.CompareTag("AttackPlayer"))
        {
            Destroy(gameObject);
        }
    }
}
