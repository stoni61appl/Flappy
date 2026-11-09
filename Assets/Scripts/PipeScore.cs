// Sugerencia general de Clean Code: usar if de una sola línea con llaves cuando sea legible.

using UnityEngine;

public class PipeScore : MonoBehaviour
{

    [SerializeField] private int points = 1; // Usar _camelCase

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Score.instance.AddPoints(points);
        }
    }
}
