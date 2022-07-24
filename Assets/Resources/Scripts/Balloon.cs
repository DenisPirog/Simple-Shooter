using UnityEngine;

public class Balloon : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float maxY;

    private void Update()
    {
        transform.Translate(direction * Time.deltaTime);

        if (transform.position.y > maxY)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
