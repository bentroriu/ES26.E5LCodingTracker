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
    Private randomizer As Integer = 0
    Dim houseImages() As Image
    Dim cityImages() As Image
    Dim metroImages() As Image
    Dim bridgeImage As Image
    Dim powerlineImage As Image


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

        Dim cost As Double = 0
        Dim powerUse As Double = 0

        Select Case selectedTool
            Case "Road"
                If e.Button = MouseButtons.Left Then
                    If Not drawingRoad Then
                        ' First click: Before starting preview, check budget
                        cost = 5000
                        If Not isSandboxMode AndAlso budget < cost Then
                            MessageBox.Show("Not enough budget!")
                            Exit Sub
                        End If

                        RoadStart = e.Location
                        drawingRoad = True

                    Else
                        ' Second click: Actually add the road
                        If Not isSandboxMode AndAlso budget < cost Then
                            MessageBox.Show("Not enough budget!")
                            drawingRoad = False ' cancel the preview if budget is not enough
                            Exit Sub
                        End If

                        Roads.Add(Tuple.Create(RoadStart, e.Location))
                        budget -= cost
                        UpdateUndoButtonState()
                        drawingRoad = False
                        pnlMapGrid.Invalidate()
                    End If
                End If
            Case "Bridge"
                cost = 15000
                If Not isSandboxMode AndAlso budget < cost Then
                    MessageBox.Show("Not enough budget!")
                    Return
                End If
                Dim bridgesrect As New Rectangle(e.X - 10, e.Y - 5, 100, 100)
                Bridges.Add(bridgesrect)
                UpdateUndoButtonState()
                pnlMapGrid.Invalidate()
            Case "Building"
                cost = 20000
                If Not isSandboxMode AndAlso budget < cost Then
                    MessageBox.Show("Not enough budget!")
                    Return
                End If
                Select Case cmbCityType.SelectedIndex
                    Case 0
                        powerUse = 3000
                    Case 1
                        powerUse = 80000
                    Case 2
                        powerUse = 500000
                End Select
                Dim buildingsrect As New Rectangle(e.X - 10, e.Y - 5, 80, 80)
                Buildings.Add(buildingsrect)
                UpdateUndoButtonState()
                pnlMapGrid.Invalidate()

            Case "PowerLine"
                cost = 10000
                If Not isSandboxMode AndAlso budget < cost Then
                    MessageBox.Show("Not enough budget!")
                    Return
                End If
                Dim powerlinesrect As New Rectangle(e.X - 10, e.Y - 5, 100, 100)
                Powerlines.Add(powerlinesrect)
                UpdateUndoButtonState()
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
        Dim RoadPen As New Pen(Color.DarkGray, 20)
        Dim previewPen As New Pen(Color.Yellow, 20)
        For Each Road In Roads
            e.Graphics.DrawLine(RoadPen, Road.Item1, Road.Item2)
        Next
        If drawingRoad Then
            e.Graphics.DrawLine(previewPen, RoadStart, RoadPreviewEnd)
        End If

        For Each rect In Bridges
            e.Graphics.DrawImage(bridgeImage, rect)
        Next

        randomizer = 0
        For Each rect In Buildings
            randomizer += 1
            If randomizer > 3 Then randomizer = 1

            Select Case cmbCityType.SelectedIndex
                Case 0
                    e.Graphics.DrawImage(houseImages(randomizer - 1), rect)
                Case 1
                    e.Graphics.DrawImage(cityImages(randomizer - 1), rect)
                Case 2
                    e.Graphics.DrawImage(metroImages(randomizer - 1), rect)
            End Select
        Next

        For Each rect In Powerlines
            e.Graphics.DrawImage(powerlineImage, rect)
        Next


    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        For Each img In houseImages
            img.Dispose()
        Next
        For Each img In cityImages
            img.Dispose()
        Next
        For Each img In metroImages
            img.Dispose()
        Next

        bridgeImage.Dispose()
        powerlineImage.Dispose()
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
        For Each img In houseImages
            img.Dispose()
        Next
        For Each img In cityImages
            img.Dispose()
        Next
        For Each img In metroImages
            img.Dispose()
        Next
        totalPower = 0
        lblBudget.Text = "Budget: ₱" & budget.ToString("N2")
        lblPower.Text = "Total Power: 0 W"
        Roads.Clear()          ' Remove all saved Roads
        Powerlines.Clear()     ' Remove all saved elements
        Buildings.Clear()
        Bridges.Clear()
        drawingRoad = False    ' Cancel any in-progress Road
        pnlMapGrid.Invalidate()
        houseImages = {My.Resources.house5, My.Resources.house4, My.Resources.house1}
        cityImages = {My.Resources.house3, My.Resources.house2, My.Resources.bldg2}
        metroImages = {My.Resources.bldg3, My.Resources.bldg4, My.Resources.bldg5}
        bridgeImage = My.Resources.bridge
        powerlineImage = My.Resources.powerline

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
        houseImages = {My.Resources.house5, My.Resources.house4, My.Resources.house1}
        cityImages = {My.Resources.house3, My.Resources.house2, My.Resources.bldg2}
        metroImages = {My.Resources.bldg3, My.Resources.bldg4, My.Resources.bldg5}
        bridgeImage = My.Resources.bridge
        powerlineImage = My.Resources.powerline

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
        btnUndobridge.Enabled = Bridges.Count > 0
        btnundobuilding.Enabled = Buildings.Count > 0
        btnundopowerline.Enabled = Powerlines.Count > 0
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim player As New System.Media.SoundPlayer(My.Resources.THEMESONG)
        If CheckBox1.Checked = True Then
            player.Play()
        Else
            player.Stop()
        End If
    End Sub

    Private Sub btnUndobridge_Click(sender As Object, e As EventArgs) Handles btnUndobridge.Click
        If Bridges.Count > 0 Then
            Bridges.RemoveAt(Bridges.Count - 1)  ' Remove the most recent road
            pnlMapGrid.Invalidate()         ' Redraw the panel
        End If
        Call UpdateUndoButtonState()
        budget += 15000 'reverse road spending
        lblBudget.Text = "Budget: ₱" & budget.ToString("N2")
    End Sub

    Private Sub btnundobuilding_Click(sender As Object, e As EventArgs) Handles btnundobuilding.Click
        If Buildings.Count > 0 Then
            Buildings.RemoveAt(Buildings.Count - 1)  ' Remove the most recent road
            pnlMapGrid.Invalidate()         ' Redraw the panel
        End If
        Call UpdateUndoButtonState()
        budget += 20000 'reverse road spending
        lblBudget.Text = "Budget: ₱" & budget.ToString("N2")
        Select Case cmbCityType.SelectedIndex
            Case 0
                totalPower -= 3000
            Case 1
                totalPower -= 80000
            Case 2
                totalPower -= 500000
        End Select
        lblPower.Text = "Total Power: " & totalPower.ToString("F0") & " W"
    End Sub

    Private Sub btnundopowerline_Click(sender As Object, e As EventArgs) Handles btnundopowerline.Click
        If Powerlines.Count > 0 Then
            Powerlines.RemoveAt(Powerlines.Count - 1)  ' Remove the most recent road
            pnlMapGrid.Invalidate()         ' Redraw the panel
        End If
        Call UpdateUndoButtonState()
        budget += 10000 'reverse road spending
        lblBudget.Text = "Budget: ₱" & budget.ToString("N2")
    End Sub
End Class
