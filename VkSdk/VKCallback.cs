using System;
using Android.Runtime;
using Com.VK.Api.Sdk.Exceptions;
using Com.VK.Api.Sdk.Auth;

namespace VKontakte
{

    public class ActionCallback<T> : Java.Lang.Object, IVKAuthCallback, IJavaObject
    {
        private readonly Action<VKAccessToken> onLogin;
        private readonly Action<VKAuthException> onLoginFailed;

        public ActionCallback(Action<VKAccessToken> onSuccess, Action<VKAuthException> onError)
        {
            this.onLogin = onSuccess;
            this.onLoginFailed = onError;
        }

        public void OnLogin(VKAccessToken token)
        {
            onLogin?.Invoke(token);
        }

        public void OnLoginFailed(VKAuthException authException)
        {
            onLoginFailed?.Invoke(authException);
        }
    }
}
