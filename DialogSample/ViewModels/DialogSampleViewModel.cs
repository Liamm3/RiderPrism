using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace DialogSample.ViewModels {
    public class DialogSampleViewModel : BindableBase {
        private readonly IDialogService _dialogService;
        private string _messageReceivedDialog;

        public string MessageReceivedDialog {
            get => _messageReceivedDialog;
            set => SetProperty(ref _messageReceivedDialog, value);
        }

        public DelegateCommand ShowDialogCommand { get; private set; }

        public DialogSampleViewModel(IDialogService dialogService) {
            _dialogService = dialogService;
            ShowDialogCommand = new DelegateCommand(ShowDialog);
        }

        private void ShowDialog() {
            var dialogParameters = new DialogParameters {{"message", "Message from ShowDialog()"}};
            _dialogService.ShowDialog("MessageDialog", dialogParameters, result => {
                MessageReceivedDialog = result.Result == ButtonResult.OK
                    ? result.Parameters.GetValue<string>("myParam")
                    : "Okay button not clicked";
            });
        }
    }
}
