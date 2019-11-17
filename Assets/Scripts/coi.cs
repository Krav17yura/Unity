using UnityEngine;
 
using UnityEngine.UI;
 
 

public class coi : MonoBehaviour
{
    [SerializeField] public int score;
    public Text ScoreText;
    public AudioSource AudioCoin;

    // Start is called before the first frame update
    void Start()
    {
        AudioCoin = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + score;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "coin")
        {
            Destroy(other.gameObject);
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            score++;
            Debug.Log(score);

        }
    }

}
