Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports System.Windows.Media

Namespace AdornerMessageBox
	''' <summary>
	''' Interaction logic for MessageAdornerBox.xaml
	''' </summary>
	Partial Public Class MessageAdornerBox
		Inherits Window
		#Region "Properties"
		Private privateMessageTitle As String
		Public Property MessageTitle() As String
			Get
				Return privateMessageTitle
			End Get
			Set(ByVal value As String)
				privateMessageTitle = value
			End Set
		End Property
		Private privateMessageText As String
		Public Property MessageText() As String
			Get
				Return privateMessageText
			End Get
			Set(ByVal value As String)
				privateMessageText = value
			End Set
		End Property
		Private privateFirstButtonCaption As String
		Public Property FirstButtonCaption() As String
			Get
				Return privateFirstButtonCaption
			End Get
			Set(ByVal value As String)
				privateFirstButtonCaption = value
			End Set
		End Property
		Private privateSecondButtonCaption As String
		Public Property SecondButtonCaption() As String
			Get
				Return privateSecondButtonCaption
			End Get
			Set(ByVal value As String)
				privateSecondButtonCaption = value
			End Set
		End Property
		Private privateMessageBackground As Brush
		Public Property MessageBackground() As Brush
			Get
				Return privateMessageBackground
			End Get
			Set(ByVal value As Brush)
				privateMessageBackground = value
			End Set
		End Property
		Private privateMessageTextForeground As Brush
		Public Property MessageTextForeground() As Brush
			Get
				Return privateMessageTextForeground
			End Get
			Set(ByVal value As Brush)
				privateMessageTextForeground = value
			End Set
		End Property
		#End Region
		#Region "Constructors"
		Private Sub New()
			InitializeComponent()
		End Sub

		Public Sub New(ByVal title As String, ByVal messageText As String)
			TextInitialization(title, messageText)
			DefaultBrushesInitialization()
			DefaultButtonsCaptionInitialization()
			InitializeComponent()
		End Sub

		Public Sub New(ByVal title As String, ByVal messageText As String, ByVal messageBackground As Brush)
			TextInitialization(title, messageText)
			MessageBackground = messageBackground
			DefaultBrushesInitialization()
			DefaultButtonsCaptionInitialization()
			InitializeComponent()
		End Sub
		Public Sub New(ByVal title As String, ByVal messageText As String, ByVal messageBackground As Brush, ByVal textForeground As Brush)
			TextInitialization(title, messageText)
			MessageBackground = messageBackground
			MessageTextForeground = textForeground
			DefaultButtonsCaptionInitialization()
			InitializeComponent()
		End Sub
		#End Region
		Private Sub TextInitialization(ByVal title As String, ByVal messageText As String)
			MessageTitle = title
			MessageText = messageText
		End Sub

		Public Overridable Sub DefaultBrushesInitialization()
			If MessageBackground Is Nothing Then
				MessageBackground = New SolidColorBrush(Colors.DeepSkyBlue)
			End If
			MessageTextForeground = New SolidColorBrush(Colors.White)
		End Sub

		Public Overridable Sub DefaultButtonsCaptionInitialization()
			FirstButtonCaption = "OK"
			SecondButtonCaption = "Cancel"
		End Sub

		Private Sub FirstButtonClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
			DialogResult = True
		End Sub

		Private Sub SecondButtonClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
			DialogResult = False
		End Sub
	End Class
End Namespace
