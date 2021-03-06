using GoogleMobileAds.Api;

namespace GoogleMobileAds.Common {
    internal interface IGoogleMobileAdsInterstitialClient {
        // Creates an InterstitialAd.
        void CreateInterstitialAd(string adUnitId);

        // Loads a new this.interstitial request.
        void LoadAd(AdRequest request);

        // Determines whether the this.interstitial has loaded.
        bool IsLoaded();

        // Shows the InterstitialAd.
        void ShowInterstitial();

        // Destroys an InterstitialAd to free up memory.
        void DestroyInterstitial();
    }
}
