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
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.pnlMapGrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMapGrid
        '
        Me.pnlMapGrid.BackColor = System.Drawing.Color.DimGray
        Me.pnlMapGrid.BackgroundImage = Global.Coding_Tracker.My.Resources.Resources.Qarvic
        Me.pnlMapGrid.Controls.Add(Me.btnUndo)
        Me.pnlMapGrid.Controls.Add(Me.Button1)
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
        Me.pnlMapGrid.Location = New System.Drawing.Point(0, 0)
        Me.pnlMapGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlMapGrid.Name = "pnlMapGrid"
        Me.pnlMapGrid.Size = New System.Drawing.Size(975, 504)
        Me.pnlMapGrid.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 10)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 19)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblMaxBuildings
        '
        Me.lblMaxBuildings.AutoSize = True
        Me.lblMaxBuildings.BackColor = System.Drawing.Color.Transparent
        Me.lblMaxBuildings.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxBuildings.Location = New System.Drawing.Point(710, 246)
        Me.lblMaxBuildings.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMaxBuildings.Name = "lblMaxBuildings"
        Me.lblMaxBuildings.Size = New System.Drawing.Size(87, 17)
        Me.lblMaxBuildings.TabIndex = 8
        Me.lblMaxBuildings.Text = "Max Buildings:"
        '
        'btnPowerLine
        '
        Me.btnPowerLine.Location = New System.Drawing.Point(39, 240)
        Me.btnPowerLine.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPowerLine.Name = "btnPowerLine"
        Me.btnPowerLine.Size = New System.Drawing.Size(95, 29)
        Me.btnPowerLine.TabIndex = 6
        Me.btnPowerLine.Text = "Powerline"
        Me.btnPowerLine.UseVisualStyleBackColor = True
        '
        'lblCityBudget
        '
        Me.lblCityBudget.AutoSize = True
        Me.lblCityBudget.BackColor = System.Drawing.Color.Transparent
        Me.lblCityBudget.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCityBudget.Location = New System.Drawing.Point(710, 223)
        Me.lblCityBudget.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCityBudget.Name = "lblCityBudget"
        Me.lblCityBudget.Size = New System.Drawing.Size(47, 17)
        Me.lblCityBudget.TabIndex = 7
        Me.lblCityBudget.Text = "Budget"
        '
        'btnBridge
        '
        Me.btnBridge.Location = New System.Drawing.Point(39, 172)
        Me.btnBridge.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBridge.Name = "btnBridge"
        Me.btnBridge.Size = New System.Drawing.Size(95, 29)
        Me.btnBridge.TabIndex = 4
        Me.btnBridge.Text = "Bridge"
        Me.btnBridge.UseVisualStyleBackColor = True
        '
        'cmbCityType
        '
        Me.cmbCityType.FormattingEnabled = True
        Me.cmbCityType.Location = New System.Drawing.Point(741, 188)
        Me.cmbCityType.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCityType.Name = "cmbCityType"
        Me.cmbCityType.Size = New System.Drawing.Size(110, 21)
        Me.cmbCityType.TabIndex = 6
        '
        'btnBuilding
        '
        Me.btnBuilding.Location = New System.Drawing.Point(39, 206)
        Me.btnBuilding.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuilding.Name = "btnBuilding"
        Me.btnBuilding.Size = New System.Drawing.Size(95, 29)
        Me.btnBuilding.TabIndex = 5
        Me.btnBuilding.Text = "Building"
        Me.btnBuilding.UseVisualStyleBackColor = True
        '
        'lblCityType
        '
        Me.lblCityType.AutoSize = True
        Me.lblCityType.BackColor = System.Drawing.Color.Transparent
        Me.lblCityType.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCityType.Location = New System.Drawing.Point(703, 162)
        Me.lblCityType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCityType.Name = "lblCityType"
        Me.lblCityType.Size = New System.Drawing.Size(66, 17)
        Me.lblCityType.TabIndex = 3
        Me.lblCityType.Text = "City Type:"
        '
        'btnRoad
        '
        Me.btnRoad.Location = New System.Drawing.Point(39, 138)
        Me.btnRoad.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRoad.Name = "btnRoad"
        Me.btnRoad.Size = New System.Drawing.Size(95, 29)
        Me.btnRoad.TabIndex = 3
        Me.btnRoad.Text = "Road"
        Me.btnRoad.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(734, 317)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(95, 29)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblBudget
        '
        Me.lblBudget.AutoSize = True
        Me.lblBudget.BackColor = System.Drawing.Color.Transparent
        Me.lblBudget.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBudget.Location = New System.Drawing.Point(703, 78)
        Me.lblBudget.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBudget.Name = "lblBudget"
        Me.lblBudget.Size = New System.Drawing.Size(50, 17)
        Me.lblBudget.TabIndex = 0
        Me.lblBudget.Text = "Budget:"
        '
        'btnSimulate
        '
        Me.btnSimulate.Location = New System.Drawing.Point(734, 274)
        Me.btnSimulate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSimulate.Name = "btnSimulate"
        Me.btnSimulate.Size = New System.Drawing.Size(95, 29)
        Me.btnSimulate.TabIndex = 4
        Me.btnSimulate.Text = "Simulate"
        Me.btnSimulate.UseVisualStyleBackColor = True
        '
        'lblPower
        '
        Me.lblPower.AutoSize = True
        Me.lblPower.BackColor = System.Drawing.Color.Transparent
        Me.lblPower.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPower.Location = New System.Drawing.Point(703, 105)
        Me.lblPower.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPower.Name = "lblPower"
        Me.lblPower.Size = New System.Drawing.Size(78, 17)
        Me.lblPower.TabIndex = 1
        Me.lblPower.Text = "Total Power:"
        '
        'cmbMode
        '
        Me.cmbMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMode.FormattingEnabled = True
        Me.cmbMode.Location = New System.Drawing.Point(741, 128)
        Me.cmbMode.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbMode.Name = "cmbMode"
        Me.cmbMode.Size = New System.Drawing.Size(110, 21)
        Me.cmbMode.TabIndex = 3
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.BackColor = System.Drawing.Color.Transparent
        Me.lblMode.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.Location = New System.Drawing.Point(703, 131)
        Me.lblMode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(43, 17)
        Me.lblMode.TabIndex = 2
        Me.lblMode.Text = "Mode:"
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(39, 340)
        Me.btnUndo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(95, 29)
        Me.btnUndo.TabIndex = 10
        Me.btnUndo.Text = "Undo Road"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 504)
        Me.Controls.Add(Me.pnlMapGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents btnUndo As Button
End Class
