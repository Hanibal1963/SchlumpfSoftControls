﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:4.0.30319.42000
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    '-Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    'Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    'mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    '''<summary>
    '''  Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SchlumpfSoft.Controls.IniFileControl.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        '''  Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Legt das Speicherverhalten der Klasse fest. ähnelt.
        '''</summary>
        Friend ReadOnly Property AutoSaveDescription() As String
            Get
                Return ResourceManager.GetString("AutoSaveDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Steuerelement zum Anzeigen und Bearbeiten des Datei- oder Abschnitts- Kommentars einer INI - Datei. ähnelt.
        '''</summary>
        Friend ReadOnly Property ClassDescriptionCommentEdit() As String
            Get
                Return ResourceManager.GetString("ClassDescriptionCommentEdit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Steuerelement zum Anzeigen des Dateiinhaltes. ähnelt.
        '''</summary>
        Friend ReadOnly Property ClassDescriptionContentView() As String
            Get
                Return ResourceManager.GetString("ClassDescriptionContentView", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Steuerelement zum Anzeigen und Bearbeiten der Einträge eines Abschnitts einer INI - Datei. ähnelt.
        '''</summary>
        Friend ReadOnly Property ClassDescriptionEntryValueEdit() As String
            Get
                Return ResourceManager.GetString("ClassDescriptionEntryValueEdit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Steuerelement zum Verwalten von INI - Dateien ähnelt.
        '''</summary>
        Friend ReadOnly Property ClassDescriptionIniFile() As String
            Get
                Return ResourceManager.GetString("ClassDescriptionIniFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Steuerelement zum Anzeigen und Bearbeiten der Abschnitts- oder Eintrags- Liste einer INI - Datei. ähnelt.
        '''</summary>
        Friend ReadOnly Property ClassDescriptionListEdit() As String
            Get
                Return ResourceManager.GetString("ClassDescriptionListEdit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Wird ausgelöst wenn sich der Kommentartext geändert hat. ähnelt.
        '''</summary>
        Friend ReadOnly Property CommentChangedDescription() As String
            Get
                Return ResourceManager.GetString("CommentChangedDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Gibt den Kommentartext zurück oder legt diesen fest. ähnelt.
        '''</summary>
        Friend ReadOnly Property CommentDescription() As String
            Get
                Return ResourceManager.GetString("CommentDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Gibt das Prefixzeichen für Kommentare zurück oder legt dieses fest. ähnelt.
        '''</summary>
        Friend ReadOnly Property CommentPrefixDescription() As String
            Get
                Return ResourceManager.GetString("CommentPrefixDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Gibt den Name des Abschnitts zurück oder legt diesen fest für den der Kommentar angezeigt werden soll. ähnelt.
        '''</summary>
        Friend ReadOnly Property CommentSectionNameDescription() As String
            Get
                Return ResourceManager.GetString("CommentSectionNameDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die ; ähnelt.
        '''</summary>
        Friend ReadOnly Property DefaultCommentPrefix() As String
            Get
                Return ResourceManager.GetString("DefaultCommentPrefix", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die NeueDatei.ini ähnelt.
        '''</summary>
        Friend ReadOnly Property DefaultFileName() As String
            Get
                Return ResourceManager.GetString("DefaultFileName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Wird ausgelöst wenn beim anlegen eines neuen Eintrags oder umbenennen eines Eintrags der Name bereits vorhanden ist. ähnelt.
        '''</summary>
        Friend ReadOnly Property EntryNameExistDescription() As String
            Get
                Return ResourceManager.GetString("EntryNameExistDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die wird ausgelöst wenn sich die Liste der Einträge geändert hat. ähnelt.
        '''</summary>
        Friend ReadOnly Property EntrysChangedDescription() As String
            Get
                Return ResourceManager.GetString("EntrysChangedDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Wird ausgelöst wenn sich der Wert eines Eintrags in einem Abschnitt geändert hat. ähnelt.
        '''</summary>
        Friend ReadOnly Property EntryValueChangedDescription() As String
            Get
                Return ResourceManager.GetString("EntryValueChangedDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Fehler beim laden der Datei &quot;{0}&quot;. ähnelt.
        '''</summary>
        Friend ReadOnly Property ErrorMsgIoException() As String
            Get
                Return ResourceManager.GetString("ErrorMsgIoException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Der Parameter &quot;{0}&quot; darf nicht NULL oder ein Leerraumzeichen sein. ähnelt.
        '''</summary>
        Friend ReadOnly Property ErrorMsgNullOrWhitSpace() As String
            Get
                Return ResourceManager.GetString("ErrorMsgNullOrWhitSpace", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Wird ausgelöst wenn sich der Dateikommentar geändert hat. ähnelt.
        '''</summary>
        Friend ReadOnly Property FileCommentChangedDescription() As String
            Get
                Return ResourceManager.GetString("FileCommentChangedDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Wird ausgelöst wenn sich der Dateiinhalt geändert hat. ähnelt.
        '''</summary>
        Friend ReadOnly Property FileContentChangedDescription() As String
            Get
                Return ResourceManager.GetString("FileContentChangedDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Gibt den Pfad und den Name zur INI-Datei zurück oder legt diesen fest. ähnelt.
        '''</summary>
        Friend ReadOnly Property FilePathDescription() As String
            Get
                Return ResourceManager.GetString("FilePathDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property IniFile() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("IniFile", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property IniFileCommentEdit() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("IniFileCommentEdit", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property IniFileContentView() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("IniFileContentView", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property IniFileEntryValueEdit() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("IniFileEntryValueEdit", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property IniFileListEdit() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("IniFileListEdit", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Gibt den Dateiinhalt zurück oder legt diesen fest. ähnelt.
        '''</summary>
        Friend ReadOnly Property LinesDescription() As String
            Get
                Return ResourceManager.GetString("LinesDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Wird ausgelöst wenn ein Eintrag hinzugefügt werden soll. ähnelt.
        '''</summary>
        Friend ReadOnly Property ListEditItemAddDescription() As String
            Get
                Return ResourceManager.GetString("ListEditItemAddDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Wird ausgelöst wenn ein Eintrag gelöscht werden soll. ähnelt.
        '''</summary>
        Friend ReadOnly Property ListEditItemRemoveDescription() As String
            Get
                Return ResourceManager.GetString("ListEditItemRemoveDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Wird ausgelöst wenn ein Eintrag umbenannt werden soll. ähnelt.
        '''</summary>
        Friend ReadOnly Property ListEditItemRenameDescription() As String
            Get
                Return ResourceManager.GetString("ListEditItemRenameDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Setzt die Elemente der Listbox oder gibt diese zurück. ähnelt.
        '''</summary>
        Friend ReadOnly Property ListeditListItemsDescription() As String
            Get
                Return ResourceManager.GetString("ListeditListItemsDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Wird ausgelöst wenn sich der gewählte Eintrag geändert hat. ähnelt.
        '''</summary>
        Friend ReadOnly Property ListEditSelectedItemChangedDescription() As String
            Get
                Return ResourceManager.GetString("ListEditSelectedItemChangedDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Wird ausgelöst wenn sich der Abschnittskommentar geändert hat. ähnelt.
        '''</summary>
        Friend ReadOnly Property SectionCommentChangedDescription() As String
            Get
                Return ResourceManager.GetString("SectionCommentChangedDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Wird ausgelöst wenn beim anlegen eines neuen Abschnitts oder umbnennen eines Abschnitts der Name bereits vorhanden ist. ähnelt.
        '''</summary>
        Friend ReadOnly Property SectionNameExistDescription() As String
            Get
                Return ResourceManager.GetString("SectionNameExistDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Wird ausgelöst wenn sich die Liste der Abschnitte geändert hat. ähnelt.
        '''</summary>
        Friend ReadOnly Property SectionsChangedDescription() As String
            Get
                Return ResourceManager.GetString("SectionsChangedDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Gibt den aktuell ausgewählten Eintrag zurück oder legt diesen fest. ähnelt.
        '''</summary>
        Friend ReadOnly Property SelectedEntryDescription() As String
            Get
                Return ResourceManager.GetString("SelectedEntryDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Gibt den aktuell ausgewählten Abschnitt zurück oder legt diesen fest. ähnelt.
        '''</summary>
        Friend ReadOnly Property SelectedSectionDescription() As String
            Get
                Return ResourceManager.GetString("SelectedSectionDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Gibt den Text der Titelzeile zurück oder legt diesen fest. ähnelt.
        '''</summary>
        Friend ReadOnly Property TitelTextDescription() As String
            Get
                Return ResourceManager.GetString("TitelTextDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Eintragswert ähnelt.
        '''</summary>
        Friend ReadOnly Property ValueDescription() As String
            Get
                Return ResourceManager.GetString("ValueDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Wird ausgelöst wenn sich der Wert geändert hat. ähnelt.
        '''</summary>
        Friend ReadOnly Property ValueEditValueChanged() As String
            Get
                Return ResourceManager.GetString("ValueEditValueChanged", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
