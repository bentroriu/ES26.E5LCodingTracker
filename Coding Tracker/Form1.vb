
Public Class Form1
        Dim budget As Double = 100000
        Dim totalPower As Double = 0
        Dim selectedTool As String = ""
        Dim isSandboxMode As Boolean = False

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            cmbMode.Items.Add("Constrained Mode")
            cmbMode.Items.Add("Sandbox Mode")
            cmbMode.SelectedIndex = 0

            lblBudget.Text = "Budget: ₱" & budget.ToString("N2")
            lblPower.Text = "Total Power: 0 W"
        End Sub

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
            Dim cost As Double = 0
            Dim powerUse As Double = 0

            Select Case selectedTool
                Case "Road"
                    cost = 5000
                Case "Bridge"
                    cost = 15000
                Case "Building"
                    cost = 20000
                    powerUse = 300 ' watts
                Case "PowerLine"
                    cost = 10000
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

            ' Simple visualization: draw rectangle
            Dim g As Graphics = pnlMapGrid.CreateGraphics()
            g.FillRectangle(Brushes.LightGray, e.X, e.Y, 30, 30)
            g.DrawString(selectedTool.Substring(0, 1), Me.Font, Brushes.Black, e.X + 5, e.Y + 5)
        End Sub

        Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
            budget = 100000
            totalPower = 0
            lblBudget.Text = "Budget: ₱" & budget.ToString("N2")
            lblPower.Text = "Total Power: 0 W"
            pnlMapGrid.Invalidate() ' Clears drawing
        End Sub

        Private Sub btnSimulate_Click(sender As Object, e As EventArgs) Handles btnSimulate.Click
            MessageBox.Show("Simulation complete!" & vbCrLf & "Total Power: " & totalPower & " W")
        End Sub
    End Class

