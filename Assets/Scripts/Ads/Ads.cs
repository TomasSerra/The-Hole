using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using System.Collections;

[RequireComponent(typeof(Button))]
public class Ads : MonoBehaviour, IUnityAdsListener
{   
    private int monedas;
    public int recompensa;
    private bool recompensar = true;
    private AudioSource musica;

#if UNITY_IOS
    private string gameId = "3609684";
#elif UNITY_ANDROID
    private string gameId = "3609685";
#endif

    Button myButton;
    public string myPlacementId = "Monedas";

    void Start()
    {
        myButton = GetComponent<Button>();
        musica = GameObject.FindGameObjectWithTag("Musica").GetComponent<AudioSource>();
        // Set interactivity to be dependent on the Placement’s status:
        myButton.interactable = Advertisement.IsReady(myPlacementId);

        // Map the ShowRewardedVideo function to the button’s click listener:
        if (myButton) myButton.onClick.AddListener(ShowRewardedVideo);

        // Initialize the Ads listener and service:
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, false);
    }

    // Implement a function for showing a rewarded video ad:
    void ShowRewardedVideo()
    {
        Advertisement.Show(myPlacementId);
    }

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsReady(string placementId)
    {
        // If the ready Placement is rewarded, activate the button: 
        if (placementId == myPlacementId)
        {
            myButton.interactable = true;
        }
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            if(recompensar == true)
            {
                monedas = GetMonedas();
                monedas += recompensa;
                GuardarMonedas(monedas);
                if (musica != null) { musica.Play(); }
                StartCoroutine(Variable());
            }
            
        }
        else if (showResult == ShowResult.Skipped)
        {
            // Do not reward the user for skipping the ad.
        }
        else if (showResult == ShowResult.Failed)
        {
            if (musica != null) { musica.Play(); }
        }
    }

    public void OnUnityAdsDidError(string message)
    {
        Debug.Log("Error");
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        if (musica != null) { musica.Pause(); }
    }

    int GetMonedas()
    {
        return PlayerPrefs.GetInt("Monedas", 0);
    }

    void GuardarMonedas(int recompensaMonedas)
    {
        PlayerPrefs.SetInt("Monedas", recompensaMonedas);
    }

    IEnumerator Variable()
    {
        recompensar = false;
        yield return new WaitForSeconds(2);
        recompensar = true;
    }
}
