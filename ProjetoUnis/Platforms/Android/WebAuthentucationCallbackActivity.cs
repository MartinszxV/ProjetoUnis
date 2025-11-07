// Local: Platforms/Android/WebAuthenticatorCallbackActivity.cs
using Android.App;
using Android.Content;
using Android.Content.PM;

namespace ProjetoUnis.Namespace; // <-- Mude para o namespace do seu app

[Activity(NoHistory = true, LaunchMode = LaunchMode.SingleTop, Exported = true)]
[IntentFilter(new[] { Intent.ActionView },
    Categories = new[] { Intent.CategoryDefault, Intent.CategoryBrowsable },
    // Este DataScheme DEVE ser o seu Reverse Client ID
    DataScheme = "com.googleusercontent.apps.mfhnjsfgp3bbfk93vgkpsaaolng8rh6o-3371135215601")]
public class WebAuthenticatorCallbackActivity : Microsoft.Maui.Authentication.WebAuthenticatorCallbackActivity
{
}