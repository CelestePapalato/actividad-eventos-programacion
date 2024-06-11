using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int puntosDeDaño;

    void Update()
    {
        Mover();
        Llamar();
    }

    void Mover()
    {
        Vector2 input = Vector2.right * Input.GetAxis("Horizontal");
        transform.Translate(input * speed * Time.deltaTime);
    }

    void Llamar()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Collider2D[] collisions = Physics2D.OverlapCircleAll(transform.position, 5f);
            IInteractable enemigoCercano = null;
            float distanciaMinima = -1;
            foreach (Collider2D collision in collisions)
            {
                IInteractable presentacion;
                if (collision.gameObject.TryGetComponent<IInteractable>(out presentacion))
                {
                    float distancia = (collision.transform.position - transform.position).magnitude;
                    if (distancia < distanciaMinima || distanciaMinima < 0)
                    {
                        distanciaMinima = distancia;
                        enemigoCercano = presentacion;
                    }
                }
            }
            enemigoCercano?.Interactuar();
        }
    }
}
