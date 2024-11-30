using UnityEngine;

public class DamageScript : MonoBehaviour
{
    [SerializeField] private string playerTag = "Player";
    [SerializeField] private float minDamage = 5f;
    [SerializeField] private float maxDamage = 15f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(playerTag))
        {
            float damage = Random.Range(minDamage, maxDamage);
            collision.gameObject.GetComponent<LifeTotalScript>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}