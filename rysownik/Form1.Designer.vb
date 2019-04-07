<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PlikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CzyszczenieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KoniecToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KolorPisakaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KolorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WybierzGruboscToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlikToolStripMenuItem, Me.KolorPisakaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(445, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PlikToolStripMenuItem
        '
        Me.PlikToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CzyszczenieToolStripMenuItem, Me.KoniecToolStripMenuItem})
        Me.PlikToolStripMenuItem.Name = "PlikToolStripMenuItem"
        Me.PlikToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.PlikToolStripMenuItem.Text = "Plik"
        '
        'CzyszczenieToolStripMenuItem
        '
        Me.CzyszczenieToolStripMenuItem.Name = "CzyszczenieToolStripMenuItem"
        Me.CzyszczenieToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.CzyszczenieToolStripMenuItem.Text = "Czyszczenie"
        '
        'KoniecToolStripMenuItem
        '
        Me.KoniecToolStripMenuItem.Name = "KoniecToolStripMenuItem"
        Me.KoniecToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.KoniecToolStripMenuItem.Text = "Koniec"
        '
        'KolorPisakaToolStripMenuItem
        '
        Me.KolorPisakaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KolorToolStripMenuItem, Me.WybierzGruboscToolStripMenuItem})
        Me.KolorPisakaToolStripMenuItem.Name = "KolorPisakaToolStripMenuItem"
        Me.KolorPisakaToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.KolorPisakaToolStripMenuItem.Text = "Kolor pisaka"
        '
        'KolorToolStripMenuItem
        '
        Me.KolorToolStripMenuItem.Name = "KolorToolStripMenuItem"
        Me.KolorToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.KolorToolStripMenuItem.Text = "wybierz kolor"
        '
        'WybierzGruboscToolStripMenuItem
        '
        Me.WybierzGruboscToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem1})
        Me.WybierzGruboscToolStripMenuItem.Name = "WybierzGruboscToolStripMenuItem"
        Me.WybierzGruboscToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.WybierzGruboscToolStripMenuItem.Text = "wybierz grubosc"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem2.Text = "1"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem3.Text = "2"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem4.Text = "3"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem5.Text = "4"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem1.Text = "5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 477)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PlikToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CzyszczenieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KoniecToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KolorPisakaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KolorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WybierzGruboscToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
