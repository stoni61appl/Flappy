using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private float _speed = 0.65f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() // Revisar: quitar el método vacío
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
