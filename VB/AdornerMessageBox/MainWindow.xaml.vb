Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports System.Windows.Media

Namespace AdornerMessageBox
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()

		End Sub

		Private Sub Button_Click_1(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim msgb As New MessageAdornerBox("Internet Connection Error", "There was a problem connecting to the internet, would you like to try again?", New SolidColorBrush(Colors.White), New SolidColorBrush(Colors.Black)) With {.FirstButtonCaption = "Yes", .SecondButtonCaption = "No"}
			If msgb.ShowDialog() = True Then
				MessageBox.Show("Please try to reconnect later")
			End If
			'else
				'MessageBox.Show("False");
		End Sub
	End Class
End Namespace
