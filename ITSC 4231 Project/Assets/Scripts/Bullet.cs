using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    public float maxDistance;

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * bulletSpeed);
        maxDistance += 1 * Time.deltaTime;
        if (maxDistance >= 5)
        {
            Destroy(this.gameObject);
        }
    }
}