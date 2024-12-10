using System;

namespace FSD_Project.Services
{
    public class LoginStateService
    {
        private bool _showLoginAlert;
        public event Action? OnChange;

        public bool ShowLoginAlert
        {
            get => _showLoginAlert;
            private set
            {
                if (_showLoginAlert != value)
                {
                    _showLoginAlert = value;
                    OnChange?.Invoke();
                }
            }
        }

        public void SetShowLoginAlert(bool value)
        {
            ShowLoginAlert = value;
        }
    }
}