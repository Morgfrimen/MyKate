using System.Windows.Controls;

namespace WpfApp.Core.Exception
{
    internal sealed class NavigationException : System.Exception
    {
        internal new string Message { get; }

        internal NavigationException(Page page) =>
            Message = $"Не удалось переключить страницу на {page.Name}";
    }
}