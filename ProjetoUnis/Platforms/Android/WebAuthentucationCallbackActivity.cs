using Android.App;
using Android.Content;
using Android.Content.PM;
using Microsoft.Maui.Authentication;

// O namespace deve ser o do seu projeto. Pelas imagens, parece ser "ProjetoUnis".
// Se o nome do seu projeto for "MauiApp4", use "MauiApp4" aqui.
namespace ProjetoUnis;

[Activity(NoHistory = true, LaunchMode = LaunchMode.SingleTop, Exported = true)]
[IntentFilter(
    // AQUI ESTÁ A CORREÇÃO: Usando os textos diretamente
    new[] { "android.intent.action.VIEW" },
    Categories = new[] { "android.intent.category.DEFAULT", "android.intent.category.BROWSABLE" },
    DataScheme = "com.mycompany.mauiapp4" // IMPORTANTE: Este deve ser o seu nome de pacote
)]
public class WebAuthenticationCallbackActivity : WebAuthenticatorCallbackActivity
{
}