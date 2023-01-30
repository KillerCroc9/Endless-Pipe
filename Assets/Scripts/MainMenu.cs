using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public Player player;

	public Text scoreLabel;
	public GameObject Cam;



    private void OnEnable()
    {
		Cam.SetActive(true);	

	}
	private void OnDisable()
    {
		Cam.SetActive(false);
    }
    public void StartGame (int mode) {
		player.StartGame(mode);
		gameObject.SetActive(false);
		Cursor.visible = false;
	}

	public void EndGame (float distanceTraveled) {
		scoreLabel.text = ((int)(distanceTraveled * 10f)).ToString();
		gameObject.SetActive(true);
		Cursor.visible = true;
	}
}