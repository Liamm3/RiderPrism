using System;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace RiderPrism.Dialogs {
    public class MessageDialogViewModel : BindableBase, IDialogAware {
        private string _message;

        public MessageDialogViewModel() {
            CloseDialogCommand = new DelegateCommand(CloseDialog);
        }

        public string Message {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public DelegateCommand CloseDialogCommand { get; }
        public string Title => "My Message Dialog";
        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog() => true;

        public void OnDialogClosed() {
        }

        public void OnDialogOpened(IDialogParameters parameters) {
            Message = parameters.GetValue<string>("message");
        }

        private void CloseDialog() {
            const ButtonResult result = ButtonResult.OK;
            var dialogParameters = new DialogParameters();
            dialogParameters.Add("resultMessage", "OK button clicked.");
            RequestClose?.Invoke(new DialogResult(result, dialogParameters));
        }
    }
}
