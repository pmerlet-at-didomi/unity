﻿using IO.Didomi.SDK.Events;
using IO.Didomi.SDK.Interfaces;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace IO.Didomi.SDK.UnityEditor
{
    /// <summary>
    /// Mock implementation of IDidomi interface that is called when the app is run on Unity.
    /// </summary>
    public class UnityEditorDidomi : IDidomi
    {
        private bool _isInitialized = false;
        private bool _disableMockUI = false;
        private Action _onReadyAction = null;

        public void AddEventListener(DidomiEventListener eventListener)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Disables showing mock UIs If platform is Unity Editor.
        /// </summary>
        public void DisableMockUI(bool disable)
        {
            _disableMockUI = disable;
        }

        public ISet<string> GetDisabledPurposeIds()
        {
            throw new NotImplementedException();
        }

        public ISet<Purpose> GetDisabledPurposes()
        {
            throw new NotImplementedException();
        }

        public ISet<string> GetDisabledVendorIds()
        {
            throw new NotImplementedException();
        }

        public ISet<Vendor> GetDisabledVendors()
        {
            throw new NotImplementedException();
        }

        public ISet<string> GetEnabledPurposeIds()
        {
            throw new NotImplementedException();
        }

        public ISet<Purpose> GetEnabledPurposes()
        {
            throw new NotImplementedException();
        }

        public ISet<string> GetEnabledVendorIds()
        {
            throw new NotImplementedException();
        }

        public ISet<Vendor> GetEnabledVendors()
        {
            throw new NotImplementedException();
        }

        public string GetJavaScriptForWebView()
        {
            throw new NotImplementedException();
        }

        public Purpose GetPurpose(string purposeId)
        {
            throw new NotImplementedException();
        }

        public ISet<string> GetRequiredPurposeIds()
        {
            throw new NotImplementedException();
        }

        public ISet<Purpose> GetRequiredPurposes()
        {
            throw new NotImplementedException();
        }

        public ISet<string> GetRequiredVendorIds()
        {
            throw new NotImplementedException();
        }

        public ISet<Vendor> GetRequiredVendors()
        {
            throw new NotImplementedException();
        }

        public IDictionary<string, string> GetText(string key)
        {
            throw new NotImplementedException();
        }

        public string GetTranslatedText(string key)
        {
            throw new NotImplementedException();
        }

        public bool GetUserConsentStatusForPurpose(string purposeId)
        {
            throw new NotImplementedException();
        }

        public bool GetUserConsentStatusForVendor(string vendorId)
        {
            throw new NotImplementedException();
        }

        public bool GetUserConsentStatusForVendorAndRequiredPurposes(string vendorId)
        {
            throw new NotImplementedException();
        }

        public bool GetUserLegitimateInterestStatusForPurpose(string purposeId)
        {
            throw new NotImplementedException();
        }

        public bool GetUserLegitimateInterestStatusForVendor(string vendorId)
        {
            throw new NotImplementedException();
        }

        public bool GetUserLegitimateInterestStatusForVendorAndRequiredPurposes(string vendorId)
        {
            throw new NotImplementedException();
        }

        public Vendor GetVendor(string vendorId)
        {
            throw new NotImplementedException();
        }

        public void HideNotice()
        {
            throw new NotImplementedException();
        }

        public void HidePreferences()
        {
            throw new NotImplementedException();
        }

        public void Initialize(
          string apiKey,
          string localConfigurationPath,
          string remoteConfigurationPath,
          string providerId,
          bool disableDidomiRemoteConfig,
          string languageCode
          )
        {
            if (_isInitialized)
            {
                return;
            }

            _isInitialized = true;

            _onReadyAction?.Invoke();
        }

        public void Initialize(
          string apiKey,
          string localConfigurationPath,
          string remoteConfigurationPath,
          string providerId,
          bool disableDidomiRemoteConfig,
          string languageCode,
          string noticeId
          )
        {
            if (_isInitialized)
            {
                return;
            }

            _isInitialized = true;

            _onReadyAction?.Invoke();
        }

        public bool IsConsentRequired()
        {
            throw new NotImplementedException();
        }

        public bool IsNoticeVisible()
        {
            throw new NotImplementedException();
        }

        public bool IsPreferencesVisible()
        {
            throw new NotImplementedException();
        }

        public bool IsReady()
        {
            return _isInitialized;
        }

        public void OnError(Action didomiCallable)
        {
            throw new NotImplementedException();
        }

        public void OnReady(Action didomiCallable)
        {
            _onReadyAction = didomiCallable;

            if (_isInitialized)
            {
                _onReadyAction?.Invoke();
            }
        }

        public void SetupUI()
        {
            if (_disableMockUI)
            {
                return;
            }

            ShowNoticeMockUI();
        }

        public void ShowPreferences()
        {
            if (_disableMockUI)
            {
                return;
            }

            ShowPreferencesMockUI();
        }

        public bool IsUserConsentStatusPartial()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
        }

        public bool SetUserAgreeToAll()
        {
            throw new NotImplementedException();
        }

        public bool SetUserConsentStatus(ISet<string> enabledPurposeIds, ISet<string> disabledPurposeIds, ISet<string> enabledVendorIds, ISet<string> disabledVendorIds)
        {
            throw new NotImplementedException();
        }

        public bool SetUserDisagreeToAll()
        {
            throw new NotImplementedException();
        }

        public bool SetUserStatus(
            ISet<string> enabledConsentPurposeIds,
            ISet<string> disabledConsentPurposeIds,
            ISet<string> enabledLIPurposeIds,
            ISet<string> disabledLIPurposeIds,
            ISet<string> enabledConsentVendorIds,
            ISet<string> disabledConsentVendorIds,
            ISet<string> enabledLIVendorIds,
            ISet<string> disabledLIVendorIds)
        {
            throw new NotImplementedException();
        }

        public bool SetUserStatus(
            bool purposesConsentStatus,
            bool purposesLIStatus,
            bool vendorsConsentStatus,
            bool vendorsLIStatus)
        {
            throw new NotImplementedException();
        }

        public bool ShouldConsentBeCollected()
        {
            throw new NotImplementedException();
        }

        public void ShowNotice()
        {
            if (_disableMockUI)
            {
                return;
            }

            ShowNoticeMockUI();
        }

        private void ShowNoticeMockUI()
        {
            GetMockUIScript().ShowNoticeUI();
        }

        private void ShowPreferencesMockUI()
        {
            GetMockUIScript().ShowPurposesUI();
        }

        private UnityEditorMockUI GetMockUIScript()
        {
            GameObject mockUI = new GameObject("DidomiPluginMockUI");
            return mockUI.AddComponent<UnityEditorMockUI>();
        }

        public void UpdateSelectedLanguage(string languageCode)
        {
            throw new NotImplementedException();
        }
    }
}
