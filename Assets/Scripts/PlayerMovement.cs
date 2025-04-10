using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private AudioSource audio;
    public AudioClip somMoeda;
    public AudioClip somHit;
    private bool jaLevouHit = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
        audio.loop = true;
        audio.Play();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Inimigo" && !jaLevouHit)
        {
            jaLevouHit = true;
            audio.PlayOneShot(somHit);
            GameController.PlayerGotHit();
        }
        else if (other.tag == "Coletavel")
        {
            audio.PlayOneShot(somMoeda);
            GameController.Collect();   
            Destroy(other.gameObject);
        }
    }
}
