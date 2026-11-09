using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem;



public class Fly : MonoBehaviour
{

    [SerializeField] private float _velocity = 1.5f;
    [SerializeField] private float _rotationSpeed = 10f;

    [SerializeField] private float _minusWeight = 0.10f; // Aclarar con Tooltip cuánto reduce el peso el impulso

    [SerializeField] private float _minPulse = 0.25f; // Sin abreviaciones | Aclarar con Tooltip el impulso mínimo y sus unidades

    private Rigidbody2D _rb; // Sin abreviaciones
    private float actualWeight = 0f; // Usar _camelCase

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame || Touchscreen.current != null && Touchscreen.current.primaryTouch.press.wasPressedThisFrame) // Revisar: separar la lectura de entrada del cálculo del impulso
        {
            float multiplicador = Mathf.Max(_minPulse,1f - (actualWeight * _minusWeight)); // Usar inglés

            _rb.linearVelocity = Vector2.up * (_velocity * multiplicador);
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rb.linearVelocity.y * _rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.GameOver();
    }

    public void AddWeight(float cant) // Usar inglés | Sin abreviaciones en cant
    {
        actualWeight += cant;

        Debug.Log("Peso actual:" + actualWeight);
    }
}
