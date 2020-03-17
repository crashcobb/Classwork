using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float scrollspeed;

    private Renderer r;
    private Vector2 savedOffset;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.Repeat(Time.time * scrollspeed, 1);
        Vector2 offset = new Vector2(0, y);
        r.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
