using UnityEngine;

public class Weightitem : MonoBehaviour // Corregir la ortografía de Weightitem
{
    [SerializeField] private float weight = 1f; // Usar _camelCase
    [SerializeField] private int points = 30; // Usar _camelCase

    [SerializeField] private float lifeTime = 10f; // Usar _camelCase

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Fly jugador = other.GetComponentInParent<Fly>(); // Usar inglés

        if (jugador != null) // Revisar: usar retorno temprano cuando no hay jugador
        {
            jugador.AddWeight(weight);
            Score.instance.AddPoints(points);

            Destroy(gameObject);
        }
    }
}
