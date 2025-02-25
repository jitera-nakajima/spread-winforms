﻿Public Class linechartstyle

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' テストデータの設定
        sheet.SetClipValue(0, 1, 1, 5, "S" & vbTab & "E" & vbTab & "W" & vbTab & "N" & vbTab & "NE")
        sheet.SetClipValue(1, 0, 1, 6, "S1" & vbTab & "50" & vbTab & "25" & vbTab & "85" & vbTab & "30" & vbTab & "26")
        sheet.SetClipValue(2, 0, 1, 6, "S2" & vbTab & "92" & vbTab & "14" & vbTab & "15" & vbTab & "24" & vbTab & "65")
        sheet.SetClipValue(3, 0, 1, 6, "S3" & vbTab & "65" & vbTab & "26" & vbTab & "70" & vbTab & "60" & vbTab & "43")
        sheet.SetClipValue(4, 0, 1, 6, "S4" & vbTab & "24" & vbTab & "80" & vbTab & "26" & vbTab & "11" & vbTab & "27")

        ' シリーズを作成
        Dim series1 As New FarPoint.Win.Chart.LineSeries()
        series1.SeriesName = "s1"
        series1.PointMarker = New FarPoint.Win.Chart.NoMarker()
        series1.SeriesNameDataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldSeriesName", "Sheet1!$A$2:$A$2", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series1.CategoryNames.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$B$1:$F$1", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series1.Values.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$B$2:$F$2")

        Dim series2 As New FarPoint.Win.Chart.LineSeries()
        series2.SeriesName = "s2"
        series2.PointMarker = New FarPoint.Win.Chart.NoMarker()
        series2.SeriesNameDataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldSeriesName", "Sheet1!$A$3:$A$3", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series2.CategoryNames.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$B$1:$F$1", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series2.Values.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$B$3:$F$3")
        Dim eh2 As New FarPoint.Win.Chart.EnhancedSolidLine(System.Drawing.Color.Blue, 2, FarPoint.Win.Chart.CompoundType.Simple, FarPoint.Win.Chart.DashType.Dot, FarPoint.Win.Chart.CapType.Flat, FarPoint.Win.Chart.JoinType.Round, _
         FarPoint.Win.Chart.ArrowType.NoArrow, FarPoint.Win.Chart.ArrowType.DiamondArrow, 2, 1)
        series2.LineBorder = eh2

        Dim series3 As New FarPoint.Win.Chart.LineSeries()
        series3.SeriesName = "s3"
        series3.PointMarker = New FarPoint.Win.Chart.BuiltinMarker(FarPoint.Win.Chart.MarkerShape.Circle, 7.0F)
        series3.PointFill = New FarPoint.Win.Chart.GradientFill(System.Drawing.Color.Olive, System.Drawing.Color.GreenYellow)
        series3.PointBorder = New FarPoint.Win.Chart.SolidLine(System.Drawing.Color.Yellow)
        series3.SeriesNameDataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldSeriesName", "Sheet1!$A$4:$A$4", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series3.CategoryNames.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$B$1:$F$1", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series3.Values.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$B$4:$F$4")
        Dim eh3 As New FarPoint.Win.Chart.EnhancedSolidLine(System.Drawing.Color.Orange, 2, FarPoint.Win.Chart.CompoundType.Simple, FarPoint.Win.Chart.DashType.Dot, FarPoint.Win.Chart.CapType.Flat, FarPoint.Win.Chart.JoinType.Round, _
         FarPoint.Win.Chart.ArrowType.NoArrow, FarPoint.Win.Chart.ArrowType.NoArrow, 1, 1)
        series3.LineBorder = eh3

        Dim series4 As New FarPoint.Win.Chart.LineSeries()
        series4.SeriesName = "s4"
        series4.PointMarker = New FarPoint.Win.Chart.BuiltinMarker(FarPoint.Win.Chart.MarkerShape.Dot, 7.0F)
        series4.PointFill = New FarPoint.Win.Chart.GradientFill(System.Drawing.Color.Pink, System.Drawing.Color.LightBlue)
        series4.PointBorder = New FarPoint.Win.Chart.SolidLine(System.Drawing.Color.Purple)
        series4.SeriesNameDataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldSeriesName", "Sheet1!$A$5:$A$5", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series4.CategoryNames.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$B$1:$F$1", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series4.Values.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$B$5:$F$5")
        Dim eh4 As New FarPoint.Win.Chart.EnhancedSolidLine(System.Drawing.Color.Red, 1, FarPoint.Win.Chart.CompoundType.[Double], FarPoint.Win.Chart.DashType.Dash, FarPoint.Win.Chart.CapType.Flat, FarPoint.Win.Chart.JoinType.Round, _
         FarPoint.Win.Chart.ArrowType.Arrow, FarPoint.Win.Chart.ArrowType.OpenArrow, 1, 2)
        series4.LineBorder = eh4

        ' プロット領域を作成
        Dim plotArea As New FarPoint.Win.Chart.YPlotArea()
        plotArea.Location = New System.Drawing.PointF(0.1F, 0.1F)
        plotArea.Size = New System.Drawing.SizeF(0.7F, 0.8F)
        plotArea.XAxis.MajorGridVisible = True
        plotArea.Series.AddRange(New FarPoint.Win.Chart.Series() {series1, series2, series3, series4})

        ' 凡例を設定
        Dim legend As New FarPoint.Win.Chart.LegendArea()
        legend.Location = New System.Drawing.PointF(0.995F, 0.5F)
        legend.AlignmentX = 1.0F
        legend.AlignmentY = 0.5F

        ' チャートモデルに各情報を追加
        Dim model As New FarPoint.Win.Chart.ChartModel()
        model.LegendAreas.Add(legend)
        model.PlotAreas.Add(plotArea)

        ' SPREADチャートにチャートモデルを設定
        Dim chart As New FarPoint.Win.Spread.Chart.SpreadChart()
        chart.Size = New Size(450, 250)
        chart.Location = New Point(0, 120)
        chart.Model = model

        ' シートにSPREADチャートを追加
        sheet.Charts.Add(chart)
    End Sub
End Class
