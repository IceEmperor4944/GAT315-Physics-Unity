using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] KeyCode spawnKey;

    void Update()
    {
        if (Input.GetKeyDown(spawnKey))
        {
            Instantiate(prefab);
        }
    }
}