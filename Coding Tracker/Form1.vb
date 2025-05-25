Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1


    Private budget As Double = 100000
    Private buildingCount As Integer = 0
    Private buildingLimit As Integer = 0
    Private drawingRoad As Boolean = False
    Private RoadStart As Point
    Private RoadPreviewEnd As Point
    Private Roads As New List(Of Tuple(Of Point, Point))
    Dim totalPower As Double = 0
    Dim selectedTool As String = ""
    Dim isSandboxMode As Boolean = False
    Private Buildings As New List(Of Rectangle)
    Private Powerlines As New List(Of Rectangle)
    Private Bridges As New List(Of Rectangle)

    Private citySettings As New Dictionary(Of String, (budget As Double, maxBuildings As Integer)) From {
        {"Small Town", (100000, 5)},
        {"City", (250000, 10)},
        {"Metro City", (500000, 20)}
    }

    ' Handlers for tool buttons now inside PictureBox (same names)
    Private Sub btnRoad_Click(sender As Object, e As EventArgs) Handles btnRoad.Click
        selectedTool = "Road"
    End Sub

    Private Sub btnBridge_Click(sender As Object, e As EventArgs) Handles btnBridge.Click
        selectedTool = "Bridge"
    End Sub

    Private Sub btnBuilding_Click(sender As Object, e As EventArgs) Handles btnBuilding.Click
        selectedTool = "Building"
    End Sub

    Private Sub btnPowerLine_Click(sender As Object, e As EventArgs) Handles btnPowerLine.Click
        selectedTool = "PowerLine"
    End Sub

    Private Sub cmbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMode.SelectedIndexChanged
        isSandboxMode = cmbMode.SelectedItem.ToString() = "Sandbox Mode"
    End Sub

    Private Sub pnlMapGrid_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlMapGrid.MouseClick
        ' Ignore clicks on the controls inside the PictureBoxen
        If selectedTool = "" Then
            MsgBox("Please select a tool from the left side", vbExclamation, "No Tool Selected.")
            Exit Sub
        End If
        For Each ctrl As Control In pnlMapGrid.Controls
            If ctrl.Bounds.Contains(e.Location) Then Exit Sub
        Next

        Dim cost As Double = 0
        Dim powerUse As Double = 0

        Select Case selectedTool
            Case "Road"

                If e.Button = MouseButtons.Left Then
                    If Not drawingRoad Then
                        RoadStart = e.Location
                        drawingRoad = True
                        cost = 5000
                    Else
                        Roads.Add(Tuple.Create(RoadStart, e.Location))
                        UpdateUndoButtonState()
                        drawingRoad = False
                        pnlMapGrid.Invalidate()
                    End If

                End If
            Case "Bridge"
                cost = 15000
                Dim bridgesRect As New Rectangle(e.X - 10, e.Y - 5, 50, 50)
                Bridges.Add(bridgesRect)
                pnlMapGrid.Invalidate()
            Case "Building"
                cost = 20000
                powerUse = 300
                Dim buildingsRect As New Rectangle(e.X - 10, e.Y - 5, 50, 50)
                Buildings.Add(buildingsRect)
                pnlMapGrid.Invalidate()
            Case "PowerLine"
                cost = 10000
                Dim powerlinesRect As New Rectangle(e.X - 10, e.Y - 5, 50, 50)
                Powerlines.Add(powerlinesRect)
                pnlMapGrid.Invalidate()
        End Select

        If Not isSandboxMode AndAlso budget < cost Then
            MessageBox.Show("Not enough budget!")
            Return
        End If

        If Not isSandboxMode Then
            budget -= cost
            lblBudget.Text = "Budget: ₱" & budget.ToString("N2")
        End If

        totalPower += powerUse
        lblPower.Text = "Total Power: " & totalPower.ToString("F0") & " W"



    End Sub
    Private Function GetLineBoundingBox(p1 As Point, p2 As Point) As Rectangle
        Dim padding As Integer = 22 ' Extra space for thick pen
        Dim left As Integer = Math.Min(p1.X, p2.X) - padding
        Dim top As Integer = Math.Min(p1.Y, p2.Y) - padding
        Dim width As Integer = Math.Abs(p1.X - p2.X) + padding * 2
        Dim height As Integer = Math.Abs(p1.Y - p2.Y) + padding * 2
        Return New Rectangle(left, top, width, height)
    End Function

    Private Sub pnlmapgrid_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlMapGrid.MouseMove
        If drawingRoad Then
            Dim oldRect As Rectangle = GetLineBoundingBox(RoadStart, RoadPreviewEnd)
            ' Update the preview endpoint
            RoadPreviewEnd = e.Location
            ' Store the new preview line area
            Dim newRect As Rectangle = GetLineBoundingBox(RoadStart, RoadPreviewEnd)
            ' Invalidate both old and new areas to avoid ghosting
            pnlMapGrid.Invalidate(Rectangle.Union(oldRect, newRect))
        End If
    End Sub
    Private Sub pnlmapgrid_Paint(sender As Object, e As PaintEventArgs) Handles pnlMapGrid.Paint
        Dim RoadPen As New Pen(Color.DarkGray, 40)
        Dim previewPen As New Pen(Color.Yellow, 40)
        For Each Road In Roads
            e.Graphics.DrawLine(RoadPen, Road.Item1, Road.Item2)
        Next

        If drawingRoad Then
            e.Graphics.DrawLine(previewPen, RoadStart, RoadPreviewEnd)
        End If

        For Each rect In Bridges
            e.Graphics.FillRectangle(Brushes.Yellow, rect)
            e.Graphics.DrawRectangle(Pens.Black, rect)
        Next
        For Each rect In Buildings
            e.Graphics.FillRectangle(Brushes.Blue, rect)
            e.Graphics.DrawRectangle(Pens.Black, rect)
        Next

        For Each rect In Powerlines
            e.Graphics.FillRectangle(Brushes.Red, rect)
            e.Graphics.DrawRectangle(Pens.Black, rect)
        Next

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Select Case cmbCityType.SelectedIndex
            Case 0
                budget = 100000
            Case 1
                budget = 250000
            Case 2
                budget = 500000
        End Select
        totalPower = 0
        lblBudget.Text = "Budget: ₱" & budget.ToString("N2")
        lblPower.Text = "Total Power: 0 W"
        Roads.Clear()          ' Remove all saved Roads
        Powerlines.Clear()     ' Remove all saved elements
        Buildings.Clear()
        Bridges.Clear()
        drawingRoad = False    ' Cancel any in-progress Road
        pnlMapGrid.Invalidate()


    End Sub

    Private Sub btnSimulate_Click(sender As Object, e As EventArgs) Handles btnSimulate.Click
        MessageBox.Show("Simulation complete!" & vbCrLf & "Total Power: " & totalPower & " W")
    End Sub

    Private Sub cmbCityType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCityType.SelectedIndexChanged
        Dim selected = cmbCityType.SelectedItem.ToString()
        Dim cityData = citySettings(selected)

        lblCityBudget.Text = "Budget: ₱" & cityData.budget.ToString("N0")
        lblBudget.Text = "Budget: ₱" & cityData.budget.ToString("N0")
        lblMaxBuildings.Text = "Max Buildings: " & cityData.maxBuildings
        Roads.Clear()          ' Remove all saved Roads
        Powerlines.Clear()     ' Remove all saved elements
        Buildings.Clear()
        Bridges.Clear()
        drawingRoad = False    ' Cancel any in-progress Road
        pnlMapGrid.Invalidate()
        Select Case cmbCityType.SelectedIndex
            Case 0
                budget = 100000
            Case 1
                budget = 250000
            Case 2
                budget = 500000
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbMode.Items.Add("Constrained Mode")
        cmbMode.Items.Add("Sandbox Mode")
        cmbMode.SelectedIndex = 0
        cmbMode.DropDownStyle = ComboBoxStyle.DropDownList

        UpdateUndoButtonState()
        lblCityBudget.Text = "Budget: ₱" & budget.ToString("N0")
        lblPower.Text = "Total Power: 0 W"

        cmbCityType.Items.AddRange(citySettings.Keys.ToArray())
        cmbCityType.SelectedIndex = 0
        cmbCityType.DropDownStyle = ComboBoxStyle.DropDownList

        Form2.Show()

        CheckBox1.Checked = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Form2.Show()
        Select Case cmbCityType.SelectedIndex
            Case 0
                budget = 100000
            Case 1
                budget = 250000
            Case 2
                budget = 500000
        End Select
        lblBudget.Text = "Budget: ₱" & budget.ToString("N2")
        lblPower.Text = "Total Power: 0 W"
        Roads.Clear()          ' Remove all saved Roads
        Powerlines.Clear()     ' Remove all saved elements
        Buildings.Clear()
        Bridges.Clear()
        drawingRoad = False    ' Cancel any in-progress Road
        pnlMapGrid.Invalidate()
        UpdateUndoButtonState()
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        If Roads.Count > 0 Then
            Roads.RemoveAt(Roads.Count - 1)  ' Remove the most recent road
            pnlMapGrid.Invalidate()         ' Redraw the panel
        End If
        Call UpdateUndoButtonState()
        budget += 5000 'reverse road spending
        lblBudget.Text = "Budget: ₱" & budget.ToString("N2")
    End Sub
    Private Sub UpdateUndoButtonState()
        btnUndo.Enabled = Roads.Count > 0
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim player As New System.Media.SoundPlayer(My.Resources.THEMESONG)
        If CheckBox1.Checked = True Then
            player.Play()
        Else
            player.Stop()
        End If
    End Sub
End Class
