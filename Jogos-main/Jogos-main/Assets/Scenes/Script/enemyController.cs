using UnityEngine;


public class enemyController : MonoBehaviour
{
    public Transform position1;
    public Transform position2;

    public float velocity;

    private bool seguindoPost1 = true;
    private Rigidbody2D rb;
    public float MinimumDistance;
    private float targetX;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        targetX = position1.position.x;
    }

    void Update()
    {
        float personagem = this.gameObject.transform.position.x;
        float distance = Mathf.Abs(personagem - targetX);

        if (distance < MinimumDistance)
        {
            if (seguindoPost1)
            {
                targetX = position2.position.x;
                seguindoPost1 = false;
            }
            else
            {
                targetX = position1.position.x;
                seguindoPost1 = true;
            }
        }

        if (personagem > targetX)
        {
            rb.linearVelocity = new Vector2(-velocity, rb.linearVelocity.y);
        }
        else
        {
            rb.linearVelocity = new Vector2(velocity, rb.linearVelocity.y);
        }
    }
}