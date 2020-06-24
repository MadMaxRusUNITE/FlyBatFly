using UnityEngine;

public class RateAppController : MonoBehaviour
{
	private string url;

	private void Start()
	{
		url = "https://play.google.com/store/apps/details?id=" + Application.identifier;
	}

	public void GoToUrl()
	{
		Application.OpenURL(url);
	}
}