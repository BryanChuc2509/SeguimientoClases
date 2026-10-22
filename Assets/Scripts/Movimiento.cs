using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            Debug.Log("Izquierda");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
            Debug.Log("Derecha");
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime);
            Debug.Log("Arriba");
        }

        if (Input.GetKey(KeyCode.DownArrow) )
        {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);
            Debug.Log("Abajo");
        }
    }
}