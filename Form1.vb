Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Public selected As String
    Public addon As String
    Public addonFnm As String
    Public selectedFnm As String
    Public folderErrMsg As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedItem.ToString()
            Case "1.19.2 Meteor (DEVELOPMENT RELEASE)"
                selected = "1.19.2 Meteor (DEVELOPMENT RELEASE)"
                selectedFnm = "meteor_1.19.2_dev.jar"
            Case "1.19 Meteor"
                selected = "1.19 Meteor"
                selectedFnm = "meteor_1.19.jar"
            Case "1.18.1 Ares"
                selected = "1.18.1 Ares"
                selectedFnm = "ares_1.18.jar"
            Case "1.17.1 Ares"
                selected = "1.17.1 Ares"
                selectedFnm = "ares_1.17.jar"
            Case "1.16.5 Ares"
                selected = "1.16.5 Ares"
                selectedFnm = "ares_1.16.jar"
            Case "1.16.5 Impact"
                selected = "1.16.5 Impact"
                selectedFnm = "impact_1.16.jar"
            Case "1.15.2 Impact"
                selected = "1.15.2 Impact"
                selectedFnm = "impact_1.15.jar"
            Case "1.12.2 Impact"
                selected = "1.12.2 Impact"
                selectedFnm = "impact_1.12.jar"
            Case "1.16.5 Inertia"
                selected = "1.16.5 Inertia"
                selectedFnm = "inertia_1.16.jar"
            Case "1.15.2 Inertia"
                selected = "1.15.2 Inertia"
                selectedFnm = "inertia_1.15.jar"
            Case "1.14.4 Inertia"
                selected = "1.14.4 Inertia"
                selectedFnm = "inertia_1.14.jar"
            Case "1.12.2 Wolfram"
                selected = "1.12.2 Wolfram"
                selectedFnm = "wolfram_1.12.jar"
            Case "1.11 Wolfram"
                selected = "1.11 Wolfram"
                selectedFnm = "wolfram_1.11.jar"
            Case "1.10 Wolfram"
                selected = "1.10 Wolfram"
                selectedFnm = "wolfram_1.10.jar"
            Case "1.9.4 Wolfram"
                selected = "1.9.4 Wolfram"
                selectedFnm = "wolfram_1.9.jar"
            Case "1.8 Wolfram"
                selected = "1.8 Wolfram"
                selectedFnm = "wolfram_1.8.jar"
        End Select
        TextBox1.Text = selected.ToString()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.SelectedItem.ToString()
            Case "1.19 SeedCrackerX"
                addon = "1.19 SeedCrackerX"
                addonFnm = "seedcrack_1.19.jar"
            Case "1.18 SeedCrackerX"
                addon = "1.18 SeedCrackerX"
                addonFnm = "seedcrack_1.18.jar"
            Case "1.17 SeedCrackerX"
                addon = "1.17 SeedCrackerX"
                addonFnm = "seedcrack_1.17.jar"
            Case "None"
                addon = "None"
        End Select
        TextBox1.Text = addon.ToString()
    End Sub
    Private Sub swapButton_Click(sender As Object, e As EventArgs) Handles swapButton.Click
        Dim strFolderName As String
        Dim strFolderExists As String

        strFolderName = "%appdata%\.minecraft\mods"
        strFolderExists = Dir(strFolderName, vbDirectory)

        If strFolderExists = "" Then
            My.Computer.FileSystem.CopyFile(
            "clients\" + selectedFnm,
            "%appdata%\mods\" + selectedFnm, overwrite:=True)
        Else
            folderErrMsg = "Folder \.minecraft\mods does not exist! Please create the folder and run again!"
            TextBox1.Text = folderErrMsg.ToString()
        End If
    End Sub

    Private Sub addonBtn_Click(sender As Object, e As EventArgs) Handles addonBtn.Click
        Dim strFolderName As String
        Dim strFolderExists As String

        strFolderName = "%appdata%\.minecraft\mods"
        strFolderExists = Dir(strFolderName, vbDirectory)

        If strFolderExists = "" Then
            My.Computer.FileSystem.CopyFile(
            ".\addons\" + addonFnm,
            "%appdata%\mods\" + addonFnm, overwrite:=True)
        Else
            folderErrMsg = "Folder \.minecraft\mods does not exist! Please create the folder and run again!"
            TextBox1.Text = folderErrMsg.ToString()
        End If
    End Sub
End Class