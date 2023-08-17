using System.Linq;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private EnemyTarget _enemyTarget;

    [SerializeField] private float _spawnTime;
    private float _currentTime;

    private void Update()
    {
        if (_currentTime > 0)
        {
            _currentTime -= Time.deltaTime;
        }
        else
        {
            Spawn();
            _currentTime = _spawnTime;
        }
    }

    private void Spawn()
    {
        Enemy enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
        enemy.Init(_enemyTarget);
    }
}
