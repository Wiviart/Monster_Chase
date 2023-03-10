using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemyPreference;
    [SerializeField] private Transform leftPos, rightPos;
    private GameObject spawnerEnemy;
    private int randomIndex;
    private int randomSide;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawner());
    }

    // Update is called once per frame
    IEnumerator EnemySpawner()
    {
        yield return new WaitForSeconds(Random.Range(1, 5));
        randomIndex = Random.Range(0, enemyPreference.Length);
        randomSide = Random.Range(0, 2);
        spawnerEnemy = Instantiate(enemyPreference[randomIndex]);

        if (randomSide == 0)
        {
            spawnerEnemy.transform.position = leftPos.position;
            spawnerEnemy.GetComponent<Enemy>().speed = Random.Range(4, 10);
        }
        else
        {
            spawnerEnemy.transform.position = rightPos.position;
            spawnerEnemy.GetComponent<Enemy>().speed = -Random.Range(4, 10);
            spawnerEnemy.transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        StartCoroutine(EnemySpawner());
    }
}
