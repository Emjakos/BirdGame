using UnityEngine;

public class InteractArea : MonoBehaviour
{
    public Transform bar;
    public float barTime;
    public float range;
    private float seconds;
    private GameObject player;
    
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        seconds = barTime;
    }

    // Update is called once per frame
    void Update()
    {
      if (new Vector2(player.transform.position.x - this.transform.position.x, player.transform.position.y - this.transform.position.y).magnitude <= range)
      {
        Debug.Log("Tick");
        seconds-=Time.deltaTime;
      }
      else 
      {
        seconds=Mathf.Min(seconds+Time.deltaTime*2, barTime);
      }
      if (seconds < 0)
      {
        seconds = barTime;
        Debug.Log("Tock");
      }
      bar.localScale = new Vector3((barTime - seconds)/barTime, bar.localScale.y, bar.localScale.z);
    }
}
