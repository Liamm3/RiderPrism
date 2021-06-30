using System;
using Prism.Services.Dialogs;

namespace RiderPrism.Core {
    public static class IDialogServiceExtensions {
        public static void ShowMessageDialog(this IDialogService dialogService,
                                             string message, Action<IDialogResult> callback) {
            var dialogParameters = new DialogParameters {{"message", message}};
            dialogService.ShowDialog("MessageDialog", dialogParameters, callback);
        }
    }
}
