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
        Me.btnSimulate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.pnlMapGrid = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.lblMaxBuildings = New System.Windows.Forms.Label()
        Me.btnPowerLine = New System.Windows.Forms.Button()
        Me.lblCityBudget = New System.Windows.Forms.Label()
        Me.btnBridge = New System.Windows.Forms.Button()
        Me.cmbCityType = New System.Windows.Forms.ComboBox()
        Me.btnBuilding = New System.Windows.Forms.Button()
        Me.lblCityType = New System.Windows.Forms.Label()
        Me.btnRoad = New System.Windows.Forms.Button()
        Me.lblBudget = New System.Windows.Forms.Label()
        Me.lblPower = New System.Windows.Forms.Label()
        Me.cmbMode = New System.Windows.Forms.ComboBox()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.pnlMapGrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSimulate
        '
        Me.btnSimulate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSimulate.BackgroundImage = CType(resources.GetObject("btnSimulate.BackgroundImage"), System.Drawing.Image)
        Me.btnSimulate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSimulate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimulate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSimulate.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimulate.Location = New System.Drawing.Point(1096, 386)
        Me.btnSimulate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSimulate.Name = "btnSimulate"
        Me.btnSimulate.Size = New System.Drawing.Size(127, 36)
        Me.btnSimulate.TabIndex = 8
        Me.btnSimulate.Text = "Simulate"
        Me.btnSimulate.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReset.BackgroundImage = CType(resources.GetObject("btnReset.BackgroundImage"), System.Drawing.Image)
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(1096, 447)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(127, 36)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'pnlMapGrid
        '
        Me.pnlMapGrid.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlMapGrid.BackgroundImage = CType(resources.GetObject("pnlMapGrid.BackgroundImage"), System.Drawing.Image)
        Me.pnlMapGrid.Controls.Add(Me.CheckBox1)
        Me.pnlMapGrid.Controls.Add(Me.btnUndo)
        Me.pnlMapGrid.Controls.Add(Me.BtnMenu)
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
        Me.pnlMapGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlMapGrid.Name = "pnlMapGrid"
        Me.pnlMapGrid.Size = New System.Drawing.Size(1300, 620)
        Me.pnlMapGrid.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoEllipsis = True
        Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CheckBox1.BackgroundImage = CType(resources.GetObject("CheckBox1.BackgroundImage"), System.Drawing.Image)
        Me.CheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckBox1.Font = New System.Drawing.Font("Swis721 BlkOul BT", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(1096, 30)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(159, 60)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "MUSIC"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUndo.BackgroundImage = CType(resources.GetObject("btnUndo.BackgroundImage"), System.Drawing.Image)
        Me.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUndo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUndo.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUndo.Location = New System.Drawing.Point(52, 386)
        Me.btnUndo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(214, 36)
        Me.btnUndo.TabIndex = 7
        Me.btnUndo.Text = "Undo Road"
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'BtnMenu
        '
        Me.BtnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnMenu.BackgroundImage = CType(resources.GetObject("BtnMenu.BackgroundImage"), System.Drawing.Image)
        Me.BtnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMenu.Font = New System.Drawing.Font("Swis721 BlkOul BT", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMenu.Location = New System.Drawing.Point(12, 12)
        Me.BtnMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(121, 43)
        Me.BtnMenu.TabIndex = 0
        Me.BtnMenu.Text = "Menu"
        Me.BtnMenu.UseVisualStyleBackColor = False
        '
        'lblMaxBuildings
        '
        Me.lblMaxBuildings.AutoSize = True
        Me.lblMaxBuildings.BackColor = System.Drawing.Color.Transparent
        Me.lblMaxBuildings.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxBuildings.Location = New System.Drawing.Point(923, 338)
        Me.lblMaxBuildings.Name = "lblMaxBuildings"
        Me.lblMaxBuildings.Size = New System.Drawing.Size(171, 25)
        Me.lblMaxBuildings.TabIndex = 8
        Me.lblMaxBuildings.Text = "Max Buildings:"
        '
        'btnPowerLine
        '
        Me.btnPowerLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPowerLine.BackgroundImage = CType(resources.GetObject("btnPowerLine.BackgroundImage"), System.Drawing.Image)
        Me.btnPowerLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPowerLine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPowerLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPowerLine.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPowerLine.Location = New System.Drawing.Point(52, 295)
        Me.btnPowerLine.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPowerLine.Name = "btnPowerLine"
        Me.btnPowerLine.Size = New System.Drawing.Size(160, 36)
        Me.btnPowerLine.TabIndex = 6
        Me.btnPowerLine.Text = "Powerline"
        Me.btnPowerLine.UseVisualStyleBackColor = False
        '
        'lblCityBudget
        '
        Me.lblCityBudget.AutoSize = True
        Me.lblCityBudget.BackColor = System.Drawing.Color.Transparent
        Me.lblCityBudget.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCityBudget.Location = New System.Drawing.Point(923, 295)
        Me.lblCityBudget.Name = "lblCityBudget"
        Me.lblCityBudget.Size = New System.Drawing.Size(97, 25)
        Me.lblCityBudget.TabIndex = 7
        Me.lblCityBudget.Text = "Budget:"
        '
        'btnBridge
        '
        Me.btnBridge.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBridge.BackgroundImage = CType(resources.GetObject("btnBridge.BackgroundImage"), System.Drawing.Image)
        Me.btnBridge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBridge.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBridge.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBridge.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBridge.Location = New System.Drawing.Point(52, 212)
        Me.btnBridge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBridge.Name = "btnBridge"
        Me.btnBridge.Size = New System.Drawing.Size(160, 36)
        Me.btnBridge.TabIndex = 4
        Me.btnBridge.Text = "Bridge"
        Me.btnBridge.UseVisualStyleBackColor = False
        '
        'cmbCityType
        '
        Me.cmbCityType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmbCityType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbCityType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCityType.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCityType.FormattingEnabled = True
        Me.cmbCityType.ItemHeight = 25
        Me.cmbCityType.Location = New System.Drawing.Point(1048, 254)
        Me.cmbCityType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCityType.Name = "cmbCityType"
        Me.cmbCityType.Size = New System.Drawing.Size(217, 33)
        Me.cmbCityType.TabIndex = 2
        '
        'btnBuilding
        '
        Me.btnBuilding.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBuilding.BackgroundImage = CType(resources.GetObject("btnBuilding.BackgroundImage"), System.Drawing.Image)
        Me.btnBuilding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuilding.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuilding.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuilding.Location = New System.Drawing.Point(52, 254)
        Me.btnBuilding.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuilding.Name = "btnBuilding"
        Me.btnBuilding.Size = New System.Drawing.Size(160, 36)
        Me.btnBuilding.TabIndex = 5
        Me.btnBuilding.Text = "Building"
        Me.btnBuilding.UseVisualStyleBackColor = False
        '
        'lblCityType
        '
        Me.lblCityType.AutoSize = True
        Me.lblCityType.BackColor = System.Drawing.Color.Transparent
        Me.lblCityType.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCityType.Location = New System.Drawing.Point(923, 254)
        Me.lblCityType.Name = "lblCityType"
        Me.lblCityType.Size = New System.Drawing.Size(119, 25)
        Me.lblCityType.TabIndex = 3
        Me.lblCityType.Text = "City Type:"
        '
        'btnRoad
        '
        Me.btnRoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRoad.BackgroundImage = CType(resources.GetObject("btnRoad.BackgroundImage"), System.Drawing.Image)
        Me.btnRoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRoad.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoad.Location = New System.Drawing.Point(52, 170)
        Me.btnRoad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRoad.Name = "btnRoad"
        Me.btnRoad.Size = New System.Drawing.Size(160, 36)
        Me.btnRoad.TabIndex = 3
        Me.btnRoad.Text = "Road"
        Me.btnRoad.UseVisualStyleBackColor = False
        '
        'lblBudget
        '
        Me.lblBudget.AutoSize = True
        Me.lblBudget.BackColor = System.Drawing.Color.Transparent
        Me.lblBudget.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBudget.Location = New System.Drawing.Point(923, 142)
        Me.lblBudget.Name = "lblBudget"
        Me.lblBudget.Size = New System.Drawing.Size(97, 25)
        Me.lblBudget.TabIndex = 0
        Me.lblBudget.Text = "Budget:"
        '
        'lblPower
        '
        Me.lblPower.AutoSize = True
        Me.lblPower.BackColor = System.Drawing.Color.Transparent
        Me.lblPower.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPower.Location = New System.Drawing.Point(923, 181)
        Me.lblPower.Name = "lblPower"
        Me.lblPower.Size = New System.Drawing.Size(144, 25)
        Me.lblPower.TabIndex = 1
        Me.lblPower.Text = "Total Power:"
        '
        'cmbMode
        '
        Me.cmbMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmbMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbMode.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMode.FormattingEnabled = True
        Me.cmbMode.ItemHeight = 25
        Me.cmbMode.Location = New System.Drawing.Point(1048, 215)
        Me.cmbMode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbMode.Name = "cmbMode"
        Me.cmbMode.Size = New System.Drawing.Size(217, 33)
        Me.cmbMode.TabIndex = 1
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.BackColor = System.Drawing.Color.Transparent
        Me.lblMode.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.Location = New System.Drawing.Point(923, 218)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(75, 25)
        Me.lblMode.TabIndex = 2
        Me.lblMode.Text = "Mode:"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnSimulate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(1300, 620)
        Me.Controls.Add(Me.pnlMapGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MY CITY PLANNER"
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
    Friend WithEvents BtnMenu As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
