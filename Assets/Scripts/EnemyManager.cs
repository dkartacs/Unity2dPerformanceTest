using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public List<FollowWaypoints> enemies;

	void Start () {
        InvokeRepeating("MoveEnemies", 0, 1 / 10f);
	}
	
	public void Register(FollowWaypoints enemy)
    {
        enemies.Add(enemy);
    }

    private void MoveEnemies()
    {
        foreach (FollowWaypoints enemy in enemies) {
            enemy.Move();
        }
    }
}
