using UnityEngine;

public class Movement : MonoBehaviour {
    public float speed;

    void Update () {
        transform.Translate (Vector3.right * speed * Time.deltaTime);
    }
}