using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject pipePrefab;
    [SerializeField] float spawnRate = 1f;
    private float _timer = 0f;
    [SerializeField] private float heightOffset = 10f;
    void Start()
    {
        SpawnPipe();
    }

     void SpawnPipe()
     {
         float lowestPoint = transform.position.y - heightOffset;
         float highestPoint = transform.position.y + heightOffset;
         Instantiate(pipePrefab,new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0),transform.rotation);
     }
    void Update()
    {
        if(_timer < spawnRate)
        {
            _timer += Time.deltaTime;

        }
        else
        {
            SpawnPipe();
            _timer = 0;
        }
    }
}
