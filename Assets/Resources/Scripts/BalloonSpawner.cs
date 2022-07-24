using UnityEngine;
using System.Collections;

public class BalloonSpawner : MonoBehaviour
{
    [Header("Positions")]
    [SerializeField] private Transform firstLine;
    [SerializeField] private Transform secondLine;
    [SerializeField] private Transform thirdLine;

    [Space(10)]
    [SerializeField] private GameObject balloonPrefab;
    [SerializeField] private float spawnCooldown;
    [SerializeField] private float gameTime;

    private void Start()
    {
        InvokeRepeating(nameof(TrySpawnBalloons), gameTime, spawnCooldown);
    }

    private void TrySpawnBalloons()
    {
        int randomLine = Random.Range(1, 4);

        switch (randomLine)
        {
            case 1:
                SpawnBalloon(firstLine);
                break;
            case 2:
                SpawnBalloon(secondLine);
                break;
            case 3:
                SpawnBalloon(thirdLine);
                break;
        }
    }

    private void SpawnBalloon(Transform line)
    {
        Instantiate(balloonPrefab, line);
    }
}
