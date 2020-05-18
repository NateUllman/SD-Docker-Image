using UnityEngine.UI;
using UnityEngine;
public class Compass : MonoBehaviour
{
	public RawImage CompassImage;
	public Transform Player;
	public Text CompassDirectionText;

	public void Update()
	{
		//Setting a handle on the Image's uvRect
		CompassImage.uvRect = new Rect(Player.localEulerAngles.y / 360, 0, 1, 1);

		// Getting a copy of forward vector
		Vector3 forward = Player.transform.forward;
		forward.y = 0;

		//Setting angles to only 5 degree increments
		float headingAngle = Quaternion.LookRotation(forward).eulerAngles.y;
		headingAngle = 5 * (Mathf.RoundToInt(headingAngle / 5.0f));

		//Converting float to int for switch
		int displayangle;
		displayangle = Mathf.RoundToInt(headingAngle);

		//Setting the text of Compass Degree Text to the clamped value
		switch (displayangle)
		{
		case 0:
			CompassDirectionText.text = "360";
			break;
		case 360:
			CompassDirectionText.text = "360";
			break;
		case 45:
			CompassDirectionText.text = "45";
			break;
		case 90:
			CompassDirectionText.text = "90";
			break;
		case 130:
			CompassDirectionText.text = "145";
			break;
		case 180:
			CompassDirectionText.text = "180";
			break;
		case 225:
			CompassDirectionText.text = "225";
			break;
		case 270:
			CompassDirectionText.text = "270";
			break;
		default:
			CompassDirectionText.text = headingAngle.ToString ();
			break;
		}
	}
}
