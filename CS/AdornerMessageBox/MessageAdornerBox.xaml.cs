using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace AdornerMessageBox {
    /// <summary>
    /// Interaction logic for MessageAdornerBox.xaml
    /// </summary>
    public partial class MessageAdornerBox: Window {
        #region Properties
        public string MessageTitle { get; set; }
        public string MessageText { get; set; }
        public string FirstButtonCaption { get; set; }
        public string SecondButtonCaption { get; set; }
        public Brush MessageBackground { get; set; }
        public Brush MessageTextForeground { get; set; }
        #endregion
        #region Constructors
        private MessageAdornerBox() {
            InitializeComponent();
        }

        public MessageAdornerBox(string title, string messageText) {
            TextInitialization(title, messageText);
            DefaultBrushesInitialization();
            DefaultButtonsCaptionInitialization();
            InitializeComponent();
        }

        public MessageAdornerBox(string title, string messageText, Brush messageBackground) {
            TextInitialization(title, messageText);
            MessageBackground = messageBackground;
            DefaultBrushesInitialization();
            DefaultButtonsCaptionInitialization();
            InitializeComponent();
        }
        public MessageAdornerBox(string title, string messageText, Brush messageBackground, Brush textForeground) {
            TextInitialization(title, messageText);
            MessageBackground = messageBackground;
            MessageTextForeground = textForeground;
            DefaultButtonsCaptionInitialization();
            InitializeComponent();
        }
        #endregion
        private void TextInitialization(string title, string messageText) {
            MessageTitle = title;
            MessageText = messageText;
        }

        public virtual void DefaultBrushesInitialization() {
            if(MessageBackground == null)
                MessageBackground = new SolidColorBrush(Colors.DeepSkyBlue);
            MessageTextForeground = new SolidColorBrush(Colors.White);
        }

        public virtual void DefaultButtonsCaptionInitialization() {
            FirstButtonCaption = "OK";
            SecondButtonCaption = "Cancel";
        }

        private void FirstButtonClick(object sender, RoutedEventArgs e) {
            DialogResult = true;
        }

        private void SecondButtonClick(object sender, RoutedEventArgs e) {
            DialogResult = false;
        }
    }
}
