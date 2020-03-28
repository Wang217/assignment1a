using UnityEngine;

public class ObjectCollision : MonoBehaviour {
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision) {
        if(collision.collider.tag == "Fish" || collision.collider.tag == "Shark" || collision.collider.tag == "Barrel") {
            Physics2D.IgnoreLayerCollision(8, 9, true);
            Physics2D.IgnoreLayerCollision(9, 8, true);

        } else if(collision.collider.tag == "Rod") {
            Destroy(this.gameObject);

        }
    }
}
