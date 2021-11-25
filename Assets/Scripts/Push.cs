using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{

    public GameObject[] projectilePrefab;
    public Sprite[] Sprites;

    public GameObject PrefabPreview;
    public float Speed = 5;
    private GameObject NewBallSpawn;
    Vector2 pos;
    private int rnd = 0;

    void Start()
    {
        rnd = Random.Range(0, 4); //Генерируем рандомное число для рандомного шарика
        PrefabPreview.GetComponent<SpriteRenderer>().sprite = Sprites[rnd];
    }

    void Update()
    {
        ProjectileShoot();        
    }

    private void ProjectileShoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject projectileGO = (GameObject)Instantiate(projectilePrefab[rnd], transform.position, projectilePrefab[rnd].transform.rotation); //Спавним префаб с физикой
            Rigidbody2D projectileRb = projectileGO.GetComponent<Rigidbody2D>(); //Получаем свойтво Риджидбоди2Д этого префаба

            var MousePosition = Input.mousePosition; //Получаем позицию курсора на экране компуктера
            MousePosition = Camera.main.ScreenToWorldPoint(MousePosition); //Преобразуем позицию, полученную выше, в игровые координаты
            pos = new Vector2(MousePosition.x, MousePosition.y); //Создаем из этой каки вектор, по которому полетит мяч

            projectileRb.AddForce(pos * Speed, ForceMode2D.Impulse); //Пуляем мяч

            rnd = Random.Range(0, 4); //Генерируем рандомное число для рандомного шарика
            PrefabPreview.GetComponent<SpriteRenderer>().sprite = Sprites[rnd];
        }
    }
}
