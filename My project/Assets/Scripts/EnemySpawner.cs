using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private EnemyTarget _enemyTarget;

    [SerializeField] private float _spawnTime;

    private void Start()
    {
        StartCoroutine(Spawning());
    }

    private IEnumerator Spawning()
    {
        bool isSpawning = true;
        WaitForSeconds wait = new WaitForSeconds(_spawnTime);

        while (isSpawning)
        {
            Enemy enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
            enemy.Init(_enemyTarget);
            yield return wait;
        }
    }
}
