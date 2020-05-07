using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //Variables
    public float speed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    public GameObject deathScreen;

    //SFX GameObjects
    public GameObject explosionSound;
    public GameObject song;
    public GameObject deathSong;

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0.0f, 1.0f, 0.0f);
                gameObject.GetComponent<Rigidbody2D>().velocity *= speed;
            }
            else if (Input.GetKeyUp(KeyCode.W))
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0.0f, -1.0f, 0.0f);
                gameObject.GetComponent<Rigidbody2D>().velocity *= speed;
            }
            else if (Input.GetKeyUp(KeyCode.S))
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);

        deathScreen.SetActive(true);

        //SFX
        explosionSound.SetActive(true);
        song.SetActive(false);
        deathSong.SetActive(true);

        Time.timeScale = 0;
    }
}
