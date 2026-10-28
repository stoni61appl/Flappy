using UnityEngine;

public class Weightitem : MonoBehaviour
{
    [SerializeField] private int weight = 1;
    [SerializeField] private int points = 30;

    [SerializeField] private float lifeTime = 10f;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Fly jugador = other.GetComponentInParent<Fly>();

        if (jugador != null)
        {
            jugador.AddWeight(weight);
            Score.instance.AddPoints(points);

            Destroy(gameObject);
        }
    }
}
