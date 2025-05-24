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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnlMapGrid = New System.Windows.Forms.Panel()
        Me.lblMaxBuildings = New System.Windows.Forms.Label()
        Me.btnPowerLine = New System.Windows.Forms.Button()
        Me.lblCityBudget = New System.Windows.Forms.Label()
        Me.btnBridge = New System.Windows.Forms.Button()
        Me.cmbCityType = New System.Windows.Forms.ComboBox()
        Me.btnBuilding = New System.Windows.Forms.Button()
        Me.lblCityType = New System.Windows.Forms.Label()
        Me.btnRoad = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblBudget = New System.Windows.Forms.Label()
        Me.btnSimulate = New System.Windows.Forms.Button()
        Me.lblPower = New System.Windows.Forms.Label()
        Me.cmbMode = New System.Windows.Forms.ComboBox()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.pnlMapGrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMapGrid
        '
        Me.pnlMapGrid.BackColor = System.Drawing.Color.DimGray
        Me.pnlMapGrid.BackgroundImage = Global.Coding_Tracker.My.Resources.Resources.Qarvic
        Me.pnlMapGrid.Controls.Add(Me.lblMaxBuildings)
        Me.pnlMapGrid.Controls.Add(Me.btnPowerLine)
        Me.pnlMapGrid.Controls.Add(Me.lblCityBudget)
        Me.pnlMapGrid.Controls.Add(Me.btnBridge)
        Me.pnlMapGrid.Controls.Add(Me.cmbCityType)
        Me.pnlMapGrid.Controls.Add(Me.btnBuilding)
        Me.pnlMapGrid.Controls.Add(Me.lblCityType)
        Me.pnlMapGrid.Controls.Add(Me.btnRoad)
        Me.pnlMapGrid.Controls.Add(Me.btnReset)
        Me.pnlMapGrid.Controls.Add(Me.lblBudget)
        Me.pnlMapGrid.Controls.Add(Me.btnSimulate)
        Me.pnlMapGrid.Controls.Add(Me.lblPower)
        Me.pnlMapGrid.Controls.Add(Me.cmbMode)
        Me.pnlMapGrid.Controls.Add(Me.lblMode)
        Me.pnlMapGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMapGrid.Location = New System.Drawing.Point(0, 0)
        Me.pnlMapGrid.Name = "pnlMapGrid"
        Me.pnlMapGrid.Size = New System.Drawing.Size(1300, 620)
        Me.pnlMapGrid.TabIndex = 0
        '
        'lblMaxBuildings
        '
        Me.lblMaxBuildings.AutoSize = True
        Me.lblMaxBuildings.BackColor = System.Drawing.Color.Transparent
        Me.lblMaxBuildings.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxBuildings.Location = New System.Drawing.Point(947, 303)
        Me.lblMaxBuildings.Name = "lblMaxBuildings"
        Me.lblMaxBuildings.Size = New System.Drawing.Size(118, 21)
        Me.lblMaxBuildings.TabIndex = 8
        Me.lblMaxBuildings.Text = "Max Buildings:"
        '
        'btnPowerLine
        '
        Me.btnPowerLine.Location = New System.Drawing.Point(52, 296)
        Me.btnPowerLine.Name = "btnPowerLine"
        Me.btnPowerLine.Size = New System.Drawing.Size(127, 36)
        Me.btnPowerLine.TabIndex = 6
        Me.btnPowerLine.Text = "Powerline"
        Me.btnPowerLine.UseVisualStyleBackColor = True
        '
        'lblCityBudget
        '
        Me.lblCityBudget.AutoSize = True
        Me.lblCityBudget.BackColor = System.Drawing.Color.Transparent
        Me.lblCityBudget.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCityBudget.Location = New System.Drawing.Point(947, 274)
        Me.lblCityBudget.Name = "lblCityBudget"
        Me.lblCityBudget.Size = New System.Drawing.Size(59, 21)
        Me.lblCityBudget.TabIndex = 7
        Me.lblCityBudget.Text = "Budget"
        '
        'btnBridge
        '
        Me.btnBridge.Location = New System.Drawing.Point(52, 212)
        Me.btnBridge.Name = "btnBridge"
        Me.btnBridge.Size = New System.Drawing.Size(127, 36)
        Me.btnBridge.TabIndex = 4
        Me.btnBridge.Text = "Bridge"
        Me.btnBridge.UseVisualStyleBackColor = True
        '
        'cmbCityType
        '
        Me.cmbCityType.FormattingEnabled = True
        Me.cmbCityType.Location = New System.Drawing.Point(988, 231)
        Me.cmbCityType.Name = "cmbCityType"
        Me.cmbCityType.Size = New System.Drawing.Size(145, 24)
        Me.cmbCityType.TabIndex = 6
        '
        'btnBuilding
        '
        Me.btnBuilding.Location = New System.Drawing.Point(52, 254)
        Me.btnBuilding.Name = "btnBuilding"
        Me.btnBuilding.Size = New System.Drawing.Size(127, 36)
        Me.btnBuilding.TabIndex = 5
        Me.btnBuilding.Text = "Building"
        Me.btnBuilding.UseVisualStyleBackColor = True
        '
        'lblCityType
        '
        Me.lblCityType.AutoSize = True
        Me.lblCityType.BackColor = System.Drawing.Color.Transparent
        Me.lblCityType.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCityType.Location = New System.Drawing.Point(937, 199)
        Me.lblCityType.Name = "lblCityType"
        Me.lblCityType.Size = New System.Drawing.Size(83, 21)
        Me.lblCityType.TabIndex = 3
        Me.lblCityType.Text = "City Type:"
        '
        'btnRoad
        '
        Me.btnRoad.Location = New System.Drawing.Point(52, 170)
        Me.btnRoad.Name = "btnRoad"
        Me.btnRoad.Size = New System.Drawing.Size(127, 36)
        Me.btnRoad.TabIndex = 3
        Me.btnRoad.Text = "Road"
        Me.btnRoad.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(979, 390)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(127, 36)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblBudget
        '
        Me.lblBudget.AutoSize = True
        Me.lblBudget.BackColor = System.Drawing.Color.Transparent
        Me.lblBudget.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBudget.Location = New System.Drawing.Point(937, 96)
        Me.lblBudget.Name = "lblBudget"
        Me.lblBudget.Size = New System.Drawing.Size(63, 21)
        Me.lblBudget.TabIndex = 0
        Me.lblBudget.Text = "Budget:"
        '
        'btnSimulate
        '
        Me.btnSimulate.Location = New System.Drawing.Point(979, 337)
        Me.btnSimulate.Name = "btnSimulate"
        Me.btnSimulate.Size = New System.Drawing.Size(127, 36)
        Me.btnSimulate.TabIndex = 4
        Me.btnSimulate.Text = "Simulate"
        Me.btnSimulate.UseVisualStyleBackColor = True
        '
        'lblPower
        '
        Me.lblPower.AutoSize = True
        Me.lblPower.BackColor = System.Drawing.Color.Transparent
        Me.lblPower.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPower.Location = New System.Drawing.Point(937, 129)
        Me.lblPower.Name = "lblPower"
        Me.lblPower.Size = New System.Drawing.Size(99, 21)
        Me.lblPower.TabIndex = 1
        Me.lblPower.Text = "Total Power:"
        '
        'cmbMode
        '
        Me.cmbMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMode.FormattingEnabled = True
        Me.cmbMode.Location = New System.Drawing.Point(988, 158)
        Me.cmbMode.Name = "cmbMode"
        Me.cmbMode.Size = New System.Drawing.Size(145, 24)
        Me.cmbMode.TabIndex = 3
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.BackColor = System.Drawing.Color.Transparent
        Me.lblMode.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.Location = New System.Drawing.Point(937, 161)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(53, 21)
        Me.lblMode.TabIndex = 2
        Me.lblMode.Text = "Mode:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 620)
        Me.Controls.Add(Me.pnlMapGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CITY MAP BUILDER"
        Me.TopMost = True
        Me.pnlMapGrid.ResumeLayout(False)
        Me.pnlMapGrid.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMapGrid As Panel
    Friend WithEvents btnPowerLine As Button
    Friend WithEvents btnBuilding As Button
    Friend WithEvents btnBridge As Button
    Friend WithEvents btnRoad As Button
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
