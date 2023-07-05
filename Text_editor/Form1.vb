Imports System.Drawing.Printing
Imports System.IO
Public Class Form1
    Private filePath As String
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        RichTextBox1.Text = String.Empty
        filePath = String.Empty
    End Sub

    Private Sub OPenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPenToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            filePath = OpenFileDialog1.FileName

            ' Read the contents of the file and display it in the text box
            RichTextBox1.Text = File.ReadAllText(filePath)
        End If
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem1.Click
        If filePath <> String.Empty Then
            ' Save the contents of the text box to the current file
            File.WriteAllText(filePath, RichTextBox1.Text)
        Else
            ' If no file is currently open, display a SaveFileDialog to choose a new file path
            SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                ' Get the selected file path
                filePath = SaveFileDialog1.FileName

                ' Save the contents of the text box to the new file
                File.WriteAllText(filePath, RichTextBox1.Text)
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        ' Set the text to be printed
        PrintDocument1.DocumentName = filePath
        PrintDocument1.PrinterSettings = New System.Drawing.Printing.PrinterSettings()

        ' Show the print preview dialog
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PrintDocument_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Set the font and margins
        Dim font As New Font("Arial", 12)
        Dim margins As New Margins(50, 50, 50, 50)

        ' Calculate the bounds of the printable area
        Dim printableBounds As New RectangleF(e.MarginBounds.Left - margins.Left,
                                          e.MarginBounds.Top - margins.Top,
                                          e.MarginBounds.Width,
                                          e.MarginBounds.Height)

        ' Calculate the number of lines that can be printed on the page
        Dim linesPerPage As Single = printableBounds.Height / font.Height

        ' Create a StringFormat object for alignment
        Dim format As New StringFormat()

        ' Calculate the number of lines that can be printed on the current page
        Dim linesOnPage As Integer = 0
        Dim textToPrint As String = RichTextBox1.Text
        Dim stringFormat As New StringFormat()

        ' Loop through the text and print each line
        Dim lineIndex As Integer = 0
        While lineIndex < linesPerPage AndAlso textToPrint.Length > 0
            Dim lineBounds As New RectangleF(printableBounds.Left,
                                         printableBounds.Top + (lineIndex * font.Height),
                                         printableBounds.Width,
                                         font.Height)

            ' Print the line
            e.Graphics.DrawString(textToPrint, font, Brushes.Black, lineBounds, format)

            ' Remove the printed line from the remaining text
            Dim charactersFitted As Integer
            Dim linesFitted As Integer
            e.Graphics.MeasureString(textToPrint, font, lineBounds.Size, format, charactersFitted, linesFitted)
            textToPrint = textToPrint.Substring(charactersFitted)

            ' Increment the line index
            lineIndex += linesFitted
        End While

        ' If there is more text to print, indicate that another page should be printed
        e.HasMorePages = (textToPrint.Length > 0)
    End Sub

    Private Sub PrintToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem1.Click
        PrintDocument1.DocumentName = filePath
        PrintDocument1.PrinterSettings = New System.Drawing.Printing.PrinterSettings()

        ' Show the print dialog
        Dim printDialog As New PrintDialog()
        printDialog.Document = PrintDocument1
        If printDialog.ShowDialog() = DialogResult.OK Then
            ' Print the document
            PrintDocument1.Print()
        End If


    End Sub
    Private Sub SelectColor()
        ' Display the color dialog
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            ' Set the selected color to the text box
            RichTextBox1.SelectionColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.ForeColor = Color.White
        RichTextBox1.Font = New Font("Arial", 12)
    End Sub
    Private Sub SelectFont()
        ' Display the font dialog
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            ' Set the selected font to the text box
            RichTextBox1.SelectionFont = FontDialog1.Font
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        SelectFont()
    End Sub

    Private Sub FrontColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrontColorToolStripMenuItem.Click
        SelectColor()
    End Sub
    Private Sub SelectBackColor()
        ' Display the color dialog
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            ' Set the selected color to the text box
            RichTextBox1.SelectionBackColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub BackColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackColorToolStripMenuItem.Click
        SelectBackColor()
    End Sub
End Class
