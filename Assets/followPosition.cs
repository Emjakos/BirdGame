using UnityEngine;

public class followPosition : MonoBehaviour
{
    public Transform following;
    void Update()
    {
        this.transform.position = new Vector3(following.position.x, following.position.y, this.transform.position.z);
    }
}
