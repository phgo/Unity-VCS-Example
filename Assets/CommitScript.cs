using UnityEngine;

public class CommitScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.position = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0.001f, 0.01f, 0.01f);
    }
}
