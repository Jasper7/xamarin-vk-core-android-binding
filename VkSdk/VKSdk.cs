using System;
using Android.App;
using Android.Content;
using Com.VK.Api.Sdk.Exceptions;
using Com.VK.Api.Sdk.Auth;
using Com.VK.Api.Sdk;

namespace VKontakte
{
	public partial class VkSdk
    {
        public static bool OnActivityResult(int requestCode, Result resultCode, Intent data, ActionCallback<VKAccessToken> vkCallback)
        {
            return VK.OnActivityResult(requestCode, (int)resultCode, data, vkCallback);
        }

        public static bool OnActivityResult(int requestCode, Result resultCode, Intent data, Action<VKAccessToken> onResult, Action<VKAuthException> onError = null)
        {
            return VK.OnActivityResult(requestCode, (int)resultCode, data, new ActionCallback<VKAccessToken>(onResult, onError));
        }

        public static bool OnActivityResult(int requestCode, Result resultCode, Intent data, Action<VKAccessToken> onResult, Action<object> onError = null)
        {
            return VK.OnActivityResult(requestCode, (int)resultCode, data, new ActionCallback<VKAccessToken>(onResult, onError));
        }
    }
}