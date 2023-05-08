using UnityEngine;

public abstract class Ball : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float speedMultiplier = 1.1f;
    protected Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(x, y) * speed;
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rb.velocity *= speedMultiplier;
        }
    }

    public void ResetBall()
    {
        GetComponent<Renderer>().enabled = true;
        transform.position = Vector3.zero;
        rb.velocity = Vector2.zero;
        Launch();
    }
}
