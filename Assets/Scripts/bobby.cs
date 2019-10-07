using UnityEngine;
using System.Collections;

public class bobby : MonoBehaviour
{
    public AnimationCurve curve;
    public float rotspeed = .5f;

    void Start()
    {
        curve = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 1));
        curve.preWrapMode = WrapMode.PingPong;
        curve.postWrapMode = WrapMode.PingPong;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, curve.Evaluate(Time.time) / 2f + 1f, transform.position.z);
        transform.Rotate(0, rotspeed, 0);
    }
}
