using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D Rigidbody;
    public Joystick joystick;

    private Vector2 _move;

    private void FixedUpdate()
    {
        _move.x = joystick.Horizontal;
        _move.y = joystick.Vertical;
        Rigidbody.MovePosition(Rigidbody.position + _move * Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Stone")
            return;

        else
            gameObject.SetActive(false);
    }
}
