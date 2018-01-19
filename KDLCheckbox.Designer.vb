<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KDLCheckbox
    Inherits System.Windows.Forms.CheckBox

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container

        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.BackColor = System.Drawing.Color.Transparent

        Me.Name = "KDLCheckbox"
        Me.Size = New System.Drawing.Size(139, 55)
        Me.ResumeLayout(False)
        Me.PerformLayout()

        Me.Appearance = System.Windows.Forms.Appearance.Button

        Me.BackColor = System.Drawing.Color.Transparent


        Me.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Gray


        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "CheckBox1"
        Me.Size = New System.Drawing.Size(139, 55)
        Me.TabIndex = 6
        Me.Text = "Text1"
        Me.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ' Me.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 20
        '
        'KDLCheckbox
        '

    End Sub

    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
