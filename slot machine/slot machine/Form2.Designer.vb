<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lblRegras = New System.Windows.Forms.Label()
        Me.pct1 = New System.Windows.Forms.PictureBox()
        Me.lblCrd = New System.Windows.Forms.Label()
        Me.lblN3 = New System.Windows.Forms.Label()
        Me.lblN2 = New System.Windows.Forms.Label()
        Me.lblN1 = New System.Windows.Forms.Label()
        Me.bttSair = New System.Windows.Forms.Button()
        Me.bttJogar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.JogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JogarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÍndiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bttOk = New System.Windows.Forms.Button()
        Me.bttFechar = New System.Windows.Forms.Button()
        Me.menu = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.bttVoltar = New System.Windows.Forms.Button()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRegras
        '
        Me.lblRegras.AutoSize = True
        Me.lblRegras.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRegras.Location = New System.Drawing.Point(57, 33)
        Me.lblRegras.MaximumSize = New System.Drawing.Size(549, 90)
        Me.lblRegras.Name = "lblRegras"
        Me.lblRegras.Size = New System.Drawing.Size(316, 28)
        Me.lblRegras.TabIndex = 0
        Me.lblRegras.Text = "As regras do jogo são as seguintes:"
        '
        'pct1
        '
        Me.pct1.Image = CType(resources.GetObject("pct1.Image"), System.Drawing.Image)
        Me.pct1.Location = New System.Drawing.Point(470, 231)
        Me.pct1.Name = "pct1"
        Me.pct1.Size = New System.Drawing.Size(292, 176)
        Me.pct1.TabIndex = 13
        Me.pct1.TabStop = False
        Me.pct1.Visible = False
        '
        'lblCrd
        '
        Me.lblCrd.AutoSize = True
        Me.lblCrd.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCrd.Location = New System.Drawing.Point(64, 370)
        Me.lblCrd.Name = "lblCrd"
        Me.lblCrd.Size = New System.Drawing.Size(122, 37)
        Me.lblCrd.TabIndex = 12
        Me.lblCrd.Text = "Créditos:"
        Me.lblCrd.Visible = False
        '
        'lblN3
        '
        Me.lblN3.AutoSize = True
        Me.lblN3.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblN3.Location = New System.Drawing.Point(435, 149)
        Me.lblN3.Name = "lblN3"
        Me.lblN3.Size = New System.Drawing.Size(45, 54)
        Me.lblN3.TabIndex = 11
        Me.lblN3.Text = "0"
        Me.lblN3.Visible = False
        '
        'lblN2
        '
        Me.lblN2.AutoSize = True
        Me.lblN2.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblN2.Location = New System.Drawing.Point(384, 149)
        Me.lblN2.Name = "lblN2"
        Me.lblN2.Size = New System.Drawing.Size(45, 54)
        Me.lblN2.TabIndex = 10
        Me.lblN2.Text = "0"
        Me.lblN2.Visible = False
        '
        'lblN1
        '
        Me.lblN1.AutoSize = True
        Me.lblN1.BackColor = System.Drawing.SystemColors.Control
        Me.lblN1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblN1.Location = New System.Drawing.Point(333, 149)
        Me.lblN1.Name = "lblN1"
        Me.lblN1.Size = New System.Drawing.Size(45, 54)
        Me.lblN1.TabIndex = 9
        Me.lblN1.Text = "0"
        Me.lblN1.Visible = False
        '
        'bttSair
        '
        Me.bttSair.Location = New System.Drawing.Point(64, 272)
        Me.bttSair.Name = "bttSair"
        Me.bttSair.Size = New System.Drawing.Size(116, 81)
        Me.bttSair.TabIndex = 8
        Me.bttSair.Text = "Sair"
        Me.bttSair.UseVisualStyleBackColor = True
        Me.bttSair.Visible = False
        '
        'bttJogar
        '
        Me.bttJogar.Location = New System.Drawing.Point(64, 167)
        Me.bttJogar.Name = "bttJogar"
        Me.bttJogar.Size = New System.Drawing.Size(116, 81)
        Me.bttJogar.TabIndex = 7
        Me.bttJogar.Text = "Jogar"
        Me.bttJogar.UseVisualStyleBackColor = True
        Me.bttJogar.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JogoToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
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
        Me.JogarToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.JogarToolStripMenuItem.Text = "Jogar"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
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
        Me.ÍndiceToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ÍndiceToolStripMenuItem.Text = "Índice"
        '
        'AcercaToolStripMenuItem
        '
        Me.AcercaToolStripMenuItem.Name = "AcercaToolStripMenuItem"
        Me.AcercaToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.AcercaToolStripMenuItem.Text = "Acerca"
        '
        'bttOk
        '
        Me.bttOk.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttOk.Location = New System.Drawing.Point(619, 33)
        Me.bttOk.Name = "bttOk"
        Me.bttOk.Size = New System.Drawing.Size(117, 36)
        Me.bttOk.TabIndex = 15
        Me.bttOk.Text = "PRÓXIMO"
        Me.bttOk.UseVisualStyleBackColor = True
        '
        'bttFechar
        '
        Me.bttFechar.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttFechar.Location = New System.Drawing.Point(619, 33)
        Me.bttFechar.Name = "bttFechar"
        Me.bttFechar.Size = New System.Drawing.Size(117, 36)
        Me.bttFechar.TabIndex = 16
        Me.bttFechar.Text = "Vamos!"
        Me.bttFechar.UseVisualStyleBackColor = True
        Me.bttFechar.Visible = False
        '
        'menu
        '
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem4})
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(800, 24)
        Me.menu.TabIndex = 17
        Me.menu.Text = "MenuStrip2"
        Me.menu.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.ToolStripMenuItem1.Text = "Jogo"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(102, 22)
        Me.ToolStripMenuItem2.Text = "Jogar"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(102, 22)
        Me.ToolStripMenuItem3.Text = "Sair"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripMenuItem4.Text = "Ajuda"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripMenuItem5.Text = "Índice"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripMenuItem6.Text = "Acerca"
        '
        'bttVoltar
        '
        Me.bttVoltar.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttVoltar.Location = New System.Drawing.Point(619, 113)
        Me.bttVoltar.Name = "bttVoltar"
        Me.bttVoltar.Size = New System.Drawing.Size(117, 72)
        Me.bttVoltar.TabIndex = 18
        Me.bttVoltar.Text = "Voltar ao Jogo"
        Me.bttVoltar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bttVoltar)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.bttFechar)
        Me.Controls.Add(Me.bttOk)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pct1)
        Me.Controls.Add(Me.lblCrd)
        Me.Controls.Add(Me.bttSair)
        Me.Controls.Add(Me.bttJogar)
        Me.Controls.Add(Me.lblRegras)
        Me.Controls.Add(Me.lblN3)
        Me.Controls.Add(Me.lblN2)
        Me.Controls.Add(Me.lblN1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRegras As Label
    Friend WithEvents pct1 As PictureBox
    Friend WithEvents lblCrd As Label
    Friend WithEvents lblN3 As Label
    Friend WithEvents lblN2 As Label
    Friend WithEvents lblN1 As Label
    Friend WithEvents bttSair As Button
    Friend WithEvents bttJogar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents JogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JogarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÍndiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bttOk As Button
    Friend WithEvents bttFechar As Button
    Friend WithEvents menu As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents bttVoltar As Button
End Class
