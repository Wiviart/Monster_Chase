using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    // private string ENEMY_TAG = "Enemy";
    void OnTriggerEnter2D(Collider2D collider){
        if (collider.CompareTag("Enemy")) Destroy(collider.gameObject);
    }
}
