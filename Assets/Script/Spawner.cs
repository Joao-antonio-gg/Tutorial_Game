using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ItemPrefab;
    public float radius = 1f;
    public float spawnInterval = 2f; // Tempo entre spawns (em segundos)

    private float timer;

    void Start()
    {
        if (ItemPrefab == null)
        {
            Debug.LogError("ItemPrefab não está atribuído!");
        }

        timer = spawnInterval;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            SpawnObjectR();
            timer = spawnInterval; // reseta o timer
        }
    }

    void SpawnObjectR()
    {
        Vector2 randomOffset = Random.insideUnitCircle * radius;
        Vector3 spawnPosition = transform.position + new Vector3(randomOffset.x, randomOffset.y, 0);

        if (ItemPrefab != null)
        {
            Instantiate(ItemPrefab, spawnPosition, Quaternion.identity);
            Debug.Log($"Objeto instanciado em: {spawnPosition}");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
