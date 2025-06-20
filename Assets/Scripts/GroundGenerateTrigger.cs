using UnityEngine;

public class GroundGenerateTrigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (gameObject.name == "GroundLeftGenerateTrigger")
            {
                GenerateGroundOnLeft();
            }
            else if (gameObject.name == "GroundRightGenerateTrigger")
            {
                GenerateGroundOnRight();
            }
            gameObject.SetActive(false);
        }
    }

    private void GenerateGroundOnLeft()
    {

    }

    private void GenerateGroundOnRight()
    {

    }
}
