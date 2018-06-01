using UnityEngine;

public class LineSpawner : MonoBehaviour {

    public GameObject lineprefab;
    
    public GameObject SpawnBetween(Vector3 start, Vector3 end)
    {
        GameObject line = Instantiate(lineprefab);
        Line activeLine = line.GetComponent<Line>();
        activeLine.Draw(new Vector3[] { start, end });
        return line;
    }

    public void SpawnBetweenThenDestroy(Vector3 start, Vector3 end, float lifeTime)
    {
        Destroy(SpawnBetween(start, end), lifeTime);
    }
}
