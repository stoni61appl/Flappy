using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem;



public class Fly : MonoBehaviour
{

    [SerializeField] private float _velocity = 1.5f;
    [SerializeField] private float _rotationSpeed = 10f;

    [SerializeField] private float _minusWeight = 0.10f;

    [SerializeField] private float _minPulse = 0.25f;

    private Rigidbody2D _rb;
    private int actualWeight = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame || Touchscreen.current != null && Touchscreen.current.primaryTouch.press.wasPressedThisFrame)
        {
            float multiplicador = Mathf.Max(_minPulse,1f - (actualWeight * _minusWeight));

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

    public void AddWeight(int cant)
    {
        actualWeight += cant;

        Debug.Log("Peso actual:" + actualWeight);
    }
}
