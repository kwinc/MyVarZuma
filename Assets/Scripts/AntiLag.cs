using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiLag : MonoBehaviour
{
    public Collider2D TrigForDestroy;

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject); //Удаляем тот объект, который влетел в коллайдер
    }
}
