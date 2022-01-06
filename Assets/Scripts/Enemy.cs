using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed;
    public Vector3[] positions;

    private int currentTarget;

    public void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, positions[currentTarget], Speed);

        if (transform.position == positions[currentTarget])
        {
            if (currentTarget < positions.Length - 1)
                currentTarget++;
            else
                currentTarget = 0;
        }
    }
}
