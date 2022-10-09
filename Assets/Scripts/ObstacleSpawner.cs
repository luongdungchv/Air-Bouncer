using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public Transform startPos;
    public Transform endPos;

    public GameObject obstaclePrefab;

    public float increaseDuration;
    public float deltaSpeed;
    public float deltaDuration;
    public float spawnDuration;
    void Start()
    {
        StartCoroutine(Spawn());
        StartCoroutine(SpeedIncreaseOverTime());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            float spawnPosX = Random.Range(startPos.position.x, endPos.position.x);
            var obstacle = Instantiate(obstaclePrefab, new Vector2(spawnPosX, 5.5f), Quaternion.identity);
            yield return new WaitForSeconds(spawnDuration);
        }
    }
    IEnumerator SpeedIncreaseOverTime()
    {
        yield return new WaitForSeconds(increaseDuration);
        obstaclePrefab.GetComponent<Obstacle>().speed += deltaSpeed;
    }

    IEnumerator RateIncreaseOverTime()
    {
        yield return new WaitForSeconds(increaseDuration);
        spawnDuration -= deltaDuration;
    }
}
