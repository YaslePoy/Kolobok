using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BallsSpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject BallPrefab;
    [SerializeField]

    public Transform[] Positions;
    [SerializeField]

    public float MaxSpeed;
    public float SpawnTimeout;
    private float NextSpawn;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
        if (NextSpawn < Time.time) {
            NextSpawn = Time.time + SpawnTimeout;
            var transform = Positions[Random.Range(0, Positions.Length)];

            var spawned = Instantiate(BallPrefab, transform);
            var rb = spawned.GetComponent<Rigidbody2D>();
            rb.drag = Mathf.Sqrt(Random.value);
            rb.AddForce(new Vector2(0, -Mathf.Pow(Random.value, 2) * MaxSpeed));

        }
    }

    public void SpawnBall()
    {

    }
}
