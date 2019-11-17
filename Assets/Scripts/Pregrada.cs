using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using System.Collections;
using System.Linq;

public class Pregrada : MonoBehaviour

{
    private float speed = 2.0F;
    private Vector3 direction;
    private CharacterController2D player;

    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController2D>();

    }

    void Update()
    {
        direction = transform.right;
    }


void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Player")
        {
            Debug.Log("dssdsdsd");

            player.Damage(1);

            StartCoroutine(player.Knockback(0.02f, 100, player.transform.position));

        }

    }

    private void Move()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position + transform.up * 0.2F + transform.right * direction.x * 0.5F, 0.1F);

        if (colliders.Length > 0 && colliders.All(x => !x.GetComponent<CharacterController2D>())) direction *= -1.0F;

        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
    }
}
// Start is called before the first frame update


// Update is called once per frame

