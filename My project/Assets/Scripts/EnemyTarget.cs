using System.Linq;
using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3[] _positions;
    private int _currentIndex;

    private void Start()
    {
        _positions = GetComponentsInChildren<Transform>().Select(child => child.position).ToArray();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _positions[_currentIndex], _speed * Time.deltaTime);

        if (transform.position == _positions[_currentIndex])
            _currentIndex = ++_currentIndex % _positions.Length;
    }
}
