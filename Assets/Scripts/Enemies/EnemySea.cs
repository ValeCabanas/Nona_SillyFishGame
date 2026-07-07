using UnityEngine;

public class EnemySea : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            HealthComponent playerHealth = other.GetComponent<HealthComponent>();

            playerHealth.TakeDamage(playerHealth.CurrentHealth);
        }
    }

    private void Update()
    {
        gameObject.transform.position += (transform.forward *  speed * Time.deltaTime);
    }
}
