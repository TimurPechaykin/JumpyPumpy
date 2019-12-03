using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Monetization;

public class PlusMoney : MonoBehaviour
{
    public string placementId = "rewardedVideo";
    private string gameId = "3348235";
    private AudioSource plusmon;
    public Text gold;

    void Awake()
    {
        plusmon = GetComponent<AudioSource>();
        
    }
    private void Start()
    {
        if (Monetization.isSupported)
        {
            Monetization.Initialize(gameId, false);
        }
    }

    public void ShowAd()
    {
        if (Monetization.IsReady(placementId))
        {
            ShowAdCallbacks options = new ShowAdCallbacks();
            options.finishCallback = HandleShowResult;
            ShowAdPlacementContent ad = Monetization.GetPlacementContent(placementId) as ShowAdPlacementContent;
            ad.Show(options);
        }
    }

    void HandleShowResult(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + 500);
            plusmon.Play();
            gold.text = PlayerPrefs.GetInt("Money").ToString();
        }
        else if (result == ShowResult.Skipped)
        {
            Debug.LogWarning("The player skipped the video - DO NOT REWARD!");
        }
        else if (result == ShowResult.Failed)
        {
            Debug.LogError("Video failed to show");
        }
    }
}