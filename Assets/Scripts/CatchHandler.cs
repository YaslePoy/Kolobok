using UnityEditor;
using UnityEngine;

public class CatchHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag != "Ball")
            return;
        Destroy(other.gameObject);
        
        GetComponentInParent<PlayerScore>().RegisterScore();
    }
}
