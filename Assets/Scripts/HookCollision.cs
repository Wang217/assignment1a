using UnityEngine;

public class HookCollision : MonoBehaviour
{
    public HandleFishingHook hook;

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision) {
        if(collision.collider.tag == "Fish") {
            hook.SetPointScore(10);

        } else if(collision.collider.tag == "Barrel" || collision.collider.tag == "Shark") {
            HeartControl.health--;
        }
    }
}
