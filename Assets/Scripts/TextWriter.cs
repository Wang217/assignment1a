using UnityEngine;
using UnityEngine.UI;

public class TextWriter : MonoBehaviour {
    public HandleFishingHook rod;
    public Text scoreText;

    void Update() {
        scoreText.text = rod.GetPointScore().ToString();
    }
}
