namespace BlazorU.ApiRequest
{
    public class PageVisibilityService
    {
        public bool IsCounterPageHidden { get; private set; } = false;

        public event Action OnChange;

        public void HideCounterPage()
        {
            IsCounterPageHidden = true;
            NotifyStateChanged();
        }

        public void ShowCounterPage()
        {
            IsCounterPageHidden = false;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
