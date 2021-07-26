using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using RiderPrism.Core;

namespace DialogSample.ViewModels {
    public class DialogSampleViewModel : BindableBase {
        private readonly IDialogService _dialogService;
        private string _messageReceivedDialog;

        public DialogSampleViewModel(IDialogService dialogService) {
            _dialogService = dialogService;
            ShowDialogCommand = new DelegateCommand(ShowDialog);
        }

        public string MessageReceivedDialog {
            get => _messageReceivedDialog;
            set => SetProperty(ref _messageReceivedDialog, value);
        }

        public DelegateCommand ShowDialogCommand { get; }

        private void ShowDialog() {
            _dialogService.ShowMessageDialog("Message From ShowDialog()", result => {
                MessageReceivedDialog = result.Result == ButtonResult.OK
                                            ? result.Parameters.GetValue<string>("resultMessage")
                                            : "Okay button not clicked";
            });
        }
    }
}
