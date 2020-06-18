using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rbody2D;
    Animator anim;
    SpriteRenderer SR;

    // Движение
    [SerializeField] float speed = 4;
    [SerializeField] float inertia = 0.9f;
    float xMotion;

    // Прыжки
    [SerializeField] float jumpPower = 10;
    bool jumpCommand = false;
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        SR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(!jumpCommand)
        {
            jumpCommand = Input.GetButtonDown("Jump");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float input = Input.GetAxis("Horizontal");
        if(input == 0)
        {
            xMotion = rbody2D.velocity.x * inertia;
        }
        else
        {
            SR.flipX = input < 0;
            xMotion = speed * input;
        }
        rbody2D.velocity = new Vector2(xMotion, rbody2D.velocity.y);
        anim.SetFloat("xMotion",xMotion);
        if (jumpCommand)
        {
            rbody2D.velocity = new Vector2(rbody2D.velocity.x, jumpPower);
            jumpCommand = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Camera.main.GetComponent<TimedReload>().Invoke();
    }
}
