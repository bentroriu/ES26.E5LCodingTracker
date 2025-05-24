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
        Me.pnlMapGrid = New System.Windows.Forms.Panel()
        Me.grpTools = New System.Windows.Forms.GroupBox()
        Me.btnPowerLine = New System.Windows.Forms.Button()
        Me.btnBuilding = New System.Windows.Forms.Button()
        Me.btnBridge = New System.Windows.Forms.Button()
        Me.btnRoad = New System.Windows.Forms.Button()
        Me.grpProperties = New System.Windows.Forms.GroupBox()
        Me.lblMaxBuildings = New System.Windows.Forms.Label()
        Me.lblCityBudget = New System.Windows.Forms.Label()
        Me.cmbCityType = New System.Windows.Forms.ComboBox()
        Me.lblCityType = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSimulate = New System.Windows.Forms.Button()
        Me.cmbMode = New System.Windows.Forms.ComboBox()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.lblPower = New System.Windows.Forms.Label()
        Me.lblBudget = New System.Windows.Forms.Label()
        Me.grpTools.SuspendLayout()
        Me.grpProperties.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMapGrid
        '
        Me.pnlMapGrid.BackColor = System.Drawing.Color.DimGray
        Me.pnlMapGrid.Location = New System.Drawing.Point(189, 0)
        Me.pnlMapGrid.Name = "pnlMapGrid"
        Me.pnlMapGrid.Size = New System.Drawing.Size(744, 537)
        Me.pnlMapGrid.TabIndex = 0
        '
        'grpTools
        '
        Me.grpTools.Controls.Add(Me.btnPowerLine)
        Me.grpTools.Controls.Add(Me.btnBuilding)
        Me.grpTools.Controls.Add(Me.btnBridge)
        Me.grpTools.Controls.Add(Me.btnRoad)
        Me.grpTools.Location = New System.Drawing.Point(2, 147)
        Me.grpTools.Name = "grpTools"
        Me.grpTools.Size = New System.Drawing.Size(181, 253)
        Me.grpTools.TabIndex = 1
        Me.grpTools.TabStop = False
        Me.grpTools.Text = "Tools"
        '
        'btnPowerLine
        '
        Me.btnPowerLine.Location = New System.Drawing.Point(27, 170)
        Me.btnPowerLine.Name = "btnPowerLine"
        Me.btnPowerLine.Size = New System.Drawing.Size(127, 36)
        Me.btnPowerLine.TabIndex = 6
        Me.btnPowerLine.Text = "Powerline"
        Me.btnPowerLine.UseVisualStyleBackColor = True
        '
        'btnBuilding
        '
        Me.btnBuilding.Location = New System.Drawing.Point(27, 128)
        Me.btnBuilding.Name = "btnBuilding"
        Me.btnBuilding.Size = New System.Drawing.Size(127, 36)
        Me.btnBuilding.TabIndex = 5
        Me.btnBuilding.Text = "Building"
        Me.btnBuilding.UseVisualStyleBackColor = True
        '
        'btnBridge
        '
        Me.btnBridge.Location = New System.Drawing.Point(27, 86)
        Me.btnBridge.Name = "btnBridge"
        Me.btnBridge.Size = New System.Drawing.Size(127, 36)
        Me.btnBridge.TabIndex = 4
        Me.btnBridge.Text = "Bridge"
        Me.btnBridge.UseVisualStyleBackColor = True
        '
        'btnRoad
        '
        Me.btnRoad.Location = New System.Drawing.Point(27, 44)
        Me.btnRoad.Name = "btnRoad"
        Me.btnRoad.Size = New System.Drawing.Size(127, 36)
        Me.btnRoad.TabIndex = 3
        Me.btnRoad.Text = "Road"
        Me.btnRoad.UseVisualStyleBackColor = True
        '
        'grpProperties
        '
        Me.grpProperties.Controls.Add(Me.lblMaxBuildings)
        Me.grpProperties.Controls.Add(Me.lblCityBudget)
        Me.grpProperties.Controls.Add(Me.cmbCityType)
        Me.grpProperties.Controls.Add(Me.lblCityType)
        Me.grpProperties.Controls.Add(Me.btnReset)
        Me.grpProperties.Controls.Add(Me.btnSimulate)
        Me.grpProperties.Controls.Add(Me.cmbMode)
        Me.grpProperties.Controls.Add(Me.lblMode)
        Me.grpProperties.Controls.Add(Me.lblPower)
        Me.grpProperties.Controls.Add(Me.lblBudget)
        Me.grpProperties.Location = New System.Drawing.Point(939, 66)
        Me.grpProperties.Name = "grpProperties"
        Me.grpProperties.Size = New System.Drawing.Size(236, 398)
        Me.grpProperties.TabIndex = 2
        Me.grpProperties.TabStop = False
        Me.grpProperties.Text = "Properties"
        '
        'lblMaxBuildings
        '
        Me.lblMaxBuildings.AutoSize = True
        Me.lblMaxBuildings.Location = New System.Drawing.Point(25, 238)
        Me.lblMaxBuildings.Name = "lblMaxBuildings"
        Me.lblMaxBuildings.Size = New System.Drawing.Size(93, 16)
        Me.lblMaxBuildings.TabIndex = 8
        Me.lblMaxBuildings.Text = "Max Buildings:"
        '
        'lblCityBudget
        '
        Me.lblCityBudget.AutoSize = True
        Me.lblCityBudget.Location = New System.Drawing.Point(25, 209)
        Me.lblCityBudget.Name = "lblCityBudget"
        Me.lblCityBudget.Size = New System.Drawing.Size(50, 16)
        Me.lblCityBudget.TabIndex = 7
        Me.lblCityBudget.Text = "Budget"
        '
        'cmbCityType
        '
        Me.cmbCityType.FormattingEnabled = True
        Me.cmbCityType.Location = New System.Drawing.Point(66, 166)
        Me.cmbCityType.Name = "cmbCityType"
        Me.cmbCityType.Size = New System.Drawing.Size(145, 24)
        Me.cmbCityType.TabIndex = 6
        '
        'lblCityType
        '
        Me.lblCityType.AutoSize = True
        Me.lblCityType.Location = New System.Drawing.Point(15, 134)
        Me.lblCityType.Name = "lblCityType"
        Me.lblCityType.Size = New System.Drawing.Size(67, 16)
        Me.lblCityType.TabIndex = 3
        Me.lblCityType.Text = "City Type:"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(34, 334)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(127, 36)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSimulate
        '
        Me.btnSimulate.Location = New System.Drawing.Point(34, 292)
        Me.btnSimulate.Name = "btnSimulate"
        Me.btnSimulate.Size = New System.Drawing.Size(127, 36)
        Me.btnSimulate.TabIndex = 4
        Me.btnSimulate.Text = "Simulate"
        Me.btnSimulate.UseVisualStyleBackColor = True
        '
        'cmbMode
        '
        Me.cmbMode.FormattingEnabled = True
        Me.cmbMode.Location = New System.Drawing.Point(66, 93)
        Me.cmbMode.Name = "cmbMode"
        Me.cmbMode.Size = New System.Drawing.Size(145, 24)
        Me.cmbMode.TabIndex = 3
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Location = New System.Drawing.Point(15, 96)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(45, 16)
        Me.lblMode.TabIndex = 2
        Me.lblMode.Text = "Mode:"
        '
        'lblPower
        '
        Me.lblPower.AutoSize = True
        Me.lblPower.Location = New System.Drawing.Point(15, 64)
        Me.lblPower.Name = "lblPower"
        Me.lblPower.Size = New System.Drawing.Size(82, 16)
        Me.lblPower.TabIndex = 1
        Me.lblPower.Text = "Total Power:"
        '
        'lblBudget
        '
        Me.lblBudget.AutoSize = True
        Me.lblBudget.Location = New System.Drawing.Point(15, 31)
        Me.lblBudget.Name = "lblBudget"
        Me.lblBudget.Size = New System.Drawing.Size(53, 16)
        Me.lblBudget.TabIndex = 0
        Me.lblBudget.Text = "Budget:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 538)
        Me.Controls.Add(Me.grpProperties)
        Me.Controls.Add(Me.grpTools)
        Me.Controls.Add(Me.pnlMapGrid)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.grpTools.ResumeLayout(False)
        Me.grpProperties.ResumeLayout(False)
        Me.grpProperties.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMapGrid As Panel
    Friend WithEvents grpTools As GroupBox
    Friend WithEvents btnPowerLine As Button
    Friend WithEvents btnBuilding As Button
    Friend WithEvents btnBridge As Button
    Friend WithEvents btnRoad As Button
    Friend WithEvents grpProperties As GroupBox
    Friend WithEvents cmbMode As ComboBox
    Friend WithEvents lblMode As Label
    Friend WithEvents lblPower As Label
    Friend WithEvents lblBudget As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSimulate As Button
    Friend WithEvents lblCityType As Label
    Friend WithEvents cmbCityType As ComboBox
    Friend WithEvents lblCityBudget As Label
    Friend WithEvents lblMaxBuildings As Label
End Class
