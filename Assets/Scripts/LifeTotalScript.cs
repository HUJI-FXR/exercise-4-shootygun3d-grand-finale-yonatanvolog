using UnityEngine;

public class LifeTotalScript : MonoBehaviour
{
    [SerializeField] private float initialLifeTotal = 100f;
    private float lifeTotal;

    private void Start()
    {
        lifeTotal = initialLifeTotal;
    }

    public float GetInitialLifeTotal()
    {
        return initialLifeTotal;
    }
    
    public void TakeDamage(float damage)
    {
        lifeTotal -= damage;
        if (lifeTotal <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Heal(float healAmount)
    {
        lifeTotal = Mathf.Min(lifeTotal + healAmount, initialLifeTotal);
    }

    public float GetLifeTotal()
    {
        return lifeTotal;
    }
}
