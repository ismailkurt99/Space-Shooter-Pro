using UnityEngine;

public class Laser : MonoBehaviour
{
[SerializeField]
  int speed = 8;
  void Start()
  {
    transform.position = new Vector3(transform.position.x, transform.position.y, 0);
  }

  void Update()
  {
    transform.Translate(Vector3.up * speed * Time.deltaTime);

    if(transform.position.y > 8)
    {
      Destroy(gameObject);
    } 
  }
}
