using UnityEngine;
using System.Collections;

public class StoneSplash : MonoBehaviour
{
    public int Damage { get; set; }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Monster")
        {
            other.GetComponent<Monster>().TakeDamage(Damage, Element.STONE);
            Destroy(gameObject);
        }
    }
}
