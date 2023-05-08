using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private string keyUp;
    [SerializeField] private string keyDown;
    private float yBound = 3.6f;

    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKey(keyUp))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(keyDown))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        Vector2 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, -yBound, yBound);
        transform.position = pos;
    }
}
