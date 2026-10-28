using UnityEngine;

public class PipeScore : MonoBehaviour
{

    [SerializeField] private int points = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Score.instance.AddPoints(points);
        }
    }
}
