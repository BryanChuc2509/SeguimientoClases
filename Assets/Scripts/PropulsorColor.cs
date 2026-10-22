using UnityEngine;

public class Propulsor : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            // transform.Translate(Vector3.up * propulsorForce * Time.deltaTime);
            spriteRenderer.color = Color.red;
        }
        ;

        if (Input.GetKey(KeyCode.A))
        {
            // transform.Translate(Vector3.left * propulsorForce * Time.deltaTime);
            spriteRenderer.color = Color.orange;
        }
        ;

        if (Input.GetKey(KeyCode.D))
        {
            // transform.Translate(Vector3.right * propulsorForce * Time.deltaTime);
            spriteRenderer.color = Color.orange;
        }
        ;

        if (Input.GetKey(KeyCode.S))
        {
            // transform.Translate(Vector3.down * propulsorForce * Time.deltaTime);
            spriteRenderer.color = Color.yellow;
        }
        ;
    }
}
