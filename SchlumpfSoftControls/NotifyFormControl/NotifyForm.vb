'
'****************************************************************************************************************
'NotifyForm.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'


Imports System.Drawing
Imports System.ComponentModel


Namespace NotifyFormControl


	''' <summary>
	''' Control zum anzeigen von Benachrichtigungsfenstern.
	''' </summary>
	<ProvideToolboxControl("SchlumpfSoft Controls", False)>
	<Description("Control zum anzeigen von Benachrichtigungsfenstern.")>
	<ToolboxItem(GetType(NotifyForm))>
	<ToolboxItemFilter("System.Windows.Forms")>
	<ToolboxBitmap(GetType(NotifyForm), "NotyfyForm.bmp")>
	Public Class NotifyForm : Inherits Component



#Region "Eigenschaften"

		''' <summary>
		''' Legt das Aussehen des Benachrichtigungsfensters fest.
		''' </summary>
		<Browsable(True)>
		<Category("Appearance")>
		<Description("Legt das Aussehen des Benachrichtigungsfensters fest.")>
		Public Property Design As FormDesign


		''' <summary>
		''' Legt den Benachrichtigungstext fest der angezeigt werden soll.
		''' </summary>
		<Browsable(True)>
		<Category("Appearance")>
		<Description("Legt den Benachrichtigungstext fest der angezeigt werden soll.")>
		Public Property Message As String


		''' <summary>
		''' Legt die Anzeigedauer des Benachrichtigungsfensters in ms fest.
		''' </summary>
		''' <remarks>
		''' Der Wert 0 bewirkt das kein automatisches schließen des Fensters erfolgt.
		''' </remarks>
		<Browsable(True)>
		<Category("Behavior")>
		<Description("Legt die Anzeigedauer des Benachrichtigungsfensters in ms fest. (Der Wert 0 deaktiviert das automatische schließen.)")>
		Public Property ShowTime As Integer = 5000


		''' <summary>
		''' Legt das anzuzeigende Symbol im Benachrichtigungsfensters fest.
		''' </summary>
		<Browsable(True)>
		<Category("Appearance")>
		<Description("Legt das anzuzeigende Symbol des Benachrichtigungsfensters fest.")>
		Public Property Style As FormStyle


		''' <summary>
		''' Legt den Text der Titelzeile des Benachrichtigungsfensters fest.
		''' </summary>
		<Browsable(True)>
		<Category("Appearance")>
		<Description("Legt den Text der Titelzeile des Benachrichtigungsfensters fest.")>
		Public Property Title As String

#End Region


		''' <summary>
		''' Zeigt das Meldungsfenster an.
		''' </summary>
		Public Sub Show()

			Dim _image As Image = SetFormImage()
			FormTemplate.Image = _image
			FormTemplate.Title = Title
			FormTemplate.Message = Message
			FormTemplate.Showtime = ShowTime
			SetFormDesign()

		End Sub


#Region "interne Methoden"

		''' <summary>
		''' Filter für das Design des Fensters 
		''' </summary>
		Private Sub SetFormDesign()

			Select Case Design
				Case FormDesign.Bright : SetFormDesignBright()
				Case FormDesign.Colorful : SetFormDesignColorful()
				Case FormDesign.Dark : SetFormDesignDark()
			End Select

		End Sub


		''' <summary>
		''' Setzt das Design auf Hell
		''' </summary>
		Private Shared Sub SetFormDesignBright()

			FormTemplate.Background = Color.White
			FormTemplate.TextField = Color.White
			FormTemplate.TitleBar = Color.Gray
			FormTemplate.Fontcolor = Color.Black
			Dim ini As New FormTemplate
			ini.Initialize()

		End Sub


		''' <summary>
		''' Setz das Design auf Farbig
		''' </summary>
		Private Shared Sub SetFormDesignColorful()

			FormTemplate.Background = Color.LightBlue
			FormTemplate.TextField = Color.LightBlue
			FormTemplate.TitleBar = Color.LightSeaGreen
			FormTemplate.Fontcolor = Color.White
			Dim ini As New FormTemplate
			ini.Initialize()

		End Sub


		''' <summary>
		''' Setz das Design auf Dunkel
		''' </summary>
		Private Shared Sub SetFormDesignDark()

			FormTemplate.Background = Color.FromArgb(83, 79, 75)
			FormTemplate.TextField = Color.FromArgb(83, 79, 75)
			FormTemplate.TitleBar = Color.FromArgb(60, 57, 54)
			FormTemplate.Fontcolor = Color.White
			Dim ini As New FormTemplate
			ini.Initialize()

		End Sub


		''' <summary>
		''' Gibt das Symbol für das Fenster in Abhängigkeit vom Style zurück
		''' </summary>
		''' <returns></returns>
		Private Function SetFormImage() As Image

			Select Case Style

				Case FormStyle.CriticalError : Return My.Resources.NotifyForm_Error
				Case FormStyle.Exclamation : Return My.Resources.NotifyForm_Warning
				Case FormStyle.Information : Return My.Resources.NotifyForm_Info
				Case FormStyle.Question : Return My.Resources.NotifyForm_Question
				Case Else : Return Nothing

			End Select

		End Function


#End Region


	End Class


End Namespace
