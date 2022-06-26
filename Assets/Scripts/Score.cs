using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform playerObject;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(playerObject.position.z);
        scoreText.text = playerObject.position.z.ToString("0");
    }
}
