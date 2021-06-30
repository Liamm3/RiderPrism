using System;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace RiderPrism.Dialogs {
    public class MessageDialogViewModel : BindableBase, IDialogAware {
        private string _message;

        public string Message {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public DelegateCommand CloseDialogCommand { get; private set; }
        public string Title => Message;
        public event Action<IDialogResult> RequestClose;

        public MessageDialogViewModel() {
            CloseDialogCommand = new DelegateCommand(CloseDialog);
        }

        private void CloseDialog() {
            const ButtonResult result = ButtonResult.OK;
            var dialogParameters = new DialogParameters();
            dialogParameters.Add("resultMessage", "OK button clicked.");
            RequestClose?.Invoke(new DialogResult(result, dialogParameters));
        }

        public bool CanCloseDialog() => true;

        public void OnDialogClosed() {
        }

        public void OnDialogOpened(IDialogParameters parameters) {
            Message = parameters.GetValue<string>("message");
        }
    }
}
