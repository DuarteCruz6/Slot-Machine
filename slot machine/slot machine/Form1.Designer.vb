<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.bttJogar = New System.Windows.Forms.Button()
        Me.bttSair = New System.Windows.Forms.Button()
        Me.lblN1 = New System.Windows.Forms.Label()
        Me.lblN2 = New System.Windows.Forms.Label()
        Me.lblN3 = New System.Windows.Forms.Label()
        Me.tmn1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmn2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblCrd = New System.Windows.Forms.Label()
        Me.pct1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.JogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JogarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÍndiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bttJogar
        '
        Me.bttJogar.Location = New System.Drawing.Point(68, 86)
        Me.bttJogar.Name = "bttJogar"
        Me.bttJogar.Size = New System.Drawing.Size(116, 81)
        Me.bttJogar.TabIndex = 0
        Me.bttJogar.Text = "Jogar"
        Me.bttJogar.UseVisualStyleBackColor = True
        '
        'bttSair
        '
        Me.bttSair.Location = New System.Drawing.Point(68, 197)
        Me.bttSair.Name = "bttSair"
        Me.bttSair.Size = New System.Drawing.Size(116, 81)
        Me.bttSair.TabIndex = 1
        Me.bttSair.Text = "Sair"
        Me.bttSair.UseVisualStyleBackColor = True
        '
        'lblN1
        '
        Me.lblN1.AutoSize = True
        Me.lblN1.BackColor = System.Drawing.SystemColors.Control
        Me.lblN1.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblN1.Location = New System.Drawing.Point(318, 74)
        Me.lblN1.Name = "lblN1"
        Me.lblN1.Size = New System.Drawing.Size(59, 72)
        Me.lblN1.TabIndex = 2
        Me.lblN1.Text = "0"
        '
        'lblN2
        '
        Me.lblN2.AutoSize = True
        Me.lblN2.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblN2.Location = New System.Drawing.Point(383, 74)
        Me.lblN2.Name = "lblN2"
        Me.lblN2.Size = New System.Drawing.Size(59, 72)
        Me.lblN2.TabIndex = 3
        Me.lblN2.Text = "0"
        '
        'lblN3
        '
        Me.lblN3.AutoSize = True
        Me.lblN3.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblN3.Location = New System.Drawing.Point(448, 74)
        Me.lblN3.Name = "lblN3"
        Me.lblN3.Size = New System.Drawing.Size(59, 72)
        Me.lblN3.TabIndex = 4
        Me.lblN3.Text = "0"
        '
        'tmn1
        '
        '
        'tmn2
        '
        Me.tmn2.Interval = 2000
        '
        'lblCrd
        '
        Me.lblCrd.AutoSize = True
        Me.lblCrd.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCrd.Location = New System.Drawing.Point(68, 318)
        Me.lblCrd.Name = "lblCrd"
        Me.lblCrd.Size = New System.Drawing.Size(122, 37)
        Me.lblCrd.TabIndex = 5
        Me.lblCrd.Text = "Créditos:"
        '
        'pct1
        '
        Me.pct1.Image = CType(resources.GetObject("pct1.Image"), System.Drawing.Image)
        Me.pct1.Location = New System.Drawing.Point(448, 179)
        Me.pct1.Name = "pct1"
        Me.pct1.Size = New System.Drawing.Size(292, 176)
        Me.pct1.TabIndex = 6
        Me.pct1.TabStop = False
        Me.pct1.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JogoToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'JogoToolStripMenuItem
        '
        Me.JogoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JogarToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.JogoToolStripMenuItem.Name = "JogoToolStripMenuItem"
        Me.JogoToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.JogoToolStripMenuItem.Text = "Jogo"
        '
        'JogarToolStripMenuItem
        '
        Me.JogarToolStripMenuItem.Name = "JogarToolStripMenuItem"
        Me.JogarToolStripMenuItem.ShortcutKeyDisplayString = "F2"
        Me.JogarToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.JogarToolStripMenuItem.Text = "Jogar"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F4"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÍndiceToolStripMenuItem, Me.AcercaToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'ÍndiceToolStripMenuItem
        '
        Me.ÍndiceToolStripMenuItem.Name = "ÍndiceToolStripMenuItem"
        Me.ÍndiceToolStripMenuItem.ShortcutKeyDisplayString = "F1"
        Me.ÍndiceToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ÍndiceToolStripMenuItem.Text = "Índice"
        '
        'AcercaToolStripMenuItem
        '
        Me.AcercaToolStripMenuItem.Name = "AcercaToolStripMenuItem"
        Me.AcercaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AcercaToolStripMenuItem.Text = "Acerca"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 1000.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.TextBox1.Location = New System.Drawing.Point(0, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(800, 1781)
        Me.TextBox1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pct1)
        Me.Controls.Add(Me.lblCrd)
        Me.Controls.Add(Me.lblN3)
        Me.Controls.Add(Me.lblN2)
        Me.Controls.Add(Me.lblN1)
        Me.Controls.Add(Me.bttSair)
        Me.Controls.Add(Me.bttJogar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttJogar As Button
    Friend WithEvents bttSair As Button
    Friend WithEvents lblN1 As Label
    Friend WithEvents lblN2 As Label
    Friend WithEvents lblN3 As Label
    Friend WithEvents tmn1 As Timer
    Friend WithEvents tmn2 As Timer
    Friend WithEvents lblCrd As Label
    Friend WithEvents pct1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents JogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JogarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÍndiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
End Class
