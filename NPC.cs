using UnityEngine;

public class NPC : MonoBehaviour 
{

    public int health = 5;

    public int level = 1;

    public float speed = -1.2f;

    Transform position;

    Vector3 newPosition;

    private void Start()
    {
        health += level;
        print("здоровье:" + health);
        newPosition = transform.position;
    }

    private void Update()
    {
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }

}
