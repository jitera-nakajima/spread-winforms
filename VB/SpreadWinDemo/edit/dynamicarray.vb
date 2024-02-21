﻿Public Class dynamicarray

    Public Sub New()

        InitializeComponent()

        FpSpread1.Sheets.Count = 2

        ' シートの設定
        InitSheet1(FpSpread1.Sheets(0))
        InitSheet2(FpSpread1.Sheets(1))
    End Sub

    Private Sub InitSheet1(sheet As FarPoint.Win.Spread.SheetView)
        ' 動的配列数式を有効にする
        FpSpread1.AsWorkbook().WorkbookSet.CalculationEngine.CalcFeatures += GrapeCity.Spreadsheet.CalcFeatures.DynamicArray

        sheet.SetClip(0, 0, 1, 8, "顧客番号" & vbTab & "顧客名" & vbTab & "地区" & vbTab & "商品名" & vbTab & "商品分類" & vbTab & "価格" & vbTab & "数量（ソート）")
        sheet.Cells(1, 0).Formula = "SORTBY(Sheet2!A2:G51, Sheet2!G2:G51)"
        sheet.Columns(6).Width = 120
    End Sub

    Private Sub InitSheet2(sheet As FarPoint.Win.Spread.SheetView)
        ' テストデータの設定
        sheet.SetClip(0, 0, 1, 8, "顧客番号" & vbTab & "顧客名" & vbTab & "地区" & vbTab & "商品名" & vbTab & "商品分類" & vbTab & "価格" & vbTab & "数量")
        sheet.SetClip(1, 0, 1, 7, "1001" & vbTab & "亀甲　滋万" & vbTab & "関東" & vbTab & "コピー用紙" & vbTab & "紙製品" & vbTab & "3500" & vbTab & "8")
        sheet.SetClip(2, 0, 1, 7, "1002" & vbTab & "寒田　希世" & vbTab & "関東" & vbTab & "カラーコピー用紙" & vbTab & "紙製品" & vbTab & "4500" & vbTab & "5")
        sheet.SetClip(3, 0, 1, 7, "1003" & vbTab & "小和瀬　澄" & vbTab & "関東" & vbTab & "コピー用紙" & vbTab & "紙製品" & vbTab & "3500" & vbTab & "10")
        sheet.SetClip(4, 0, 1, 7, "1004" & vbTab & "宇夫　早余子" & vbTab & "関東" & vbTab & "宛名ラベル" & vbTab & "紙製品" & vbTab & "2800" & vbTab & "10")
        sheet.SetClip(5, 0, 1, 7, "1005" & vbTab & "宇田津　聖智" & vbTab & "関東" & vbTab & "カラーメモシール" & vbTab & "事務用品" & vbTab & "2800" & vbTab & "6")
        sheet.SetClip(6, 0, 1, 7, "1006" & vbTab & "茨城　昭児" & vbTab & "関東" & vbTab & "エアークッション材" & vbTab & "梱包材" & vbTab & "2800" & vbTab & "4")
        sheet.SetClip(7, 0, 1, 7, "1007" & vbTab & "石ヶ休　椎茄" & vbTab & "関東" & vbTab & "段ボール箱（大）" & vbTab & "梱包材" & vbTab & "2900" & vbTab & "10")
        sheet.SetClip(8, 0, 1, 7, "1008" & vbTab & "赤司　恵治郎" & vbTab & "関東" & vbTab & "コピー用紙" & vbTab & "紙製品" & vbTab & "3500" & vbTab & "6")
        sheet.SetClip(9, 0, 1, 7, "1009" & vbTab & "小橋　仰一" & vbTab & "関東" & vbTab & "宛名ラベル" & vbTab & "紙製品" & vbTab & "2800" & vbTab & "5")
        sheet.SetClip(10, 0, 1, 7, "1010" & vbTab & "一重　公大" & vbTab & "関東" & vbTab & "CD DVDラベル" & vbTab & "紙製品" & vbTab & "5000" & vbTab & "1")
        sheet.SetClip(11, 0, 1, 7, "1011" & vbTab & "稲並　勝五郎" & vbTab & "中部" & vbTab & "コピー用紙" & vbTab & "紙製品" & vbTab & "3500" & vbTab & "6")
        sheet.SetClip(12, 0, 1, 7, "1012" & vbTab & "穎原　紀代一" & vbTab & "中部" & vbTab & "CD DVDラベル" & vbTab & "紙製品" & vbTab & "5000" & vbTab & "4")
        sheet.SetClip(13, 0, 1, 7, "1013" & vbTab & "安士　定助" & vbTab & "中部" & vbTab & "クリアケース" & vbTab & "事務用品" & vbTab & "2500" & vbTab & "4")
        sheet.SetClip(14, 0, 1, 7, "1014" & vbTab & "今重　邦三郎" & vbTab & "中部" & vbTab & "軽量バインダー" & vbTab & "事務用品" & vbTab & "3500" & vbTab & "4")
        sheet.SetClip(15, 0, 1, 7, "1015" & vbTab & "魚見　秀里" & vbTab & "中部" & vbTab & "エアークッション材" & vbTab & "梱包材" & vbTab & "2800" & vbTab & "7")
        sheet.SetClip(16, 0, 1, 7, "1016" & vbTab & "小佐井　幸仁" & vbTab & "中部" & vbTab & "クリアケース" & vbTab & "事務用品" & vbTab & "2500" & vbTab & "1")
        sheet.SetClip(17, 0, 1, 7, "1017" & vbTab & "大高　吉左右" & vbTab & "中部" & vbTab & "カラーメモシール" & vbTab & "事務用品" & vbTab & "2800" & vbTab & "1")
        sheet.SetClip(18, 0, 1, 7, "1018" & vbTab & "上垣内　正名" & vbTab & "関西" & vbTab & "コピー用紙" & vbTab & "紙製品" & vbTab & "3500" & vbTab & "10")
        sheet.SetClip(19, 0, 1, 7, "1019" & vbTab & "金曽　憙佳" & vbTab & "関西" & vbTab & "カラーコピー用紙" & vbTab & "紙製品" & vbTab & "4500" & vbTab & "5")
        sheet.SetClip(20, 0, 1, 7, "1020" & vbTab & "吉光　定太郎" & vbTab & "関西" & vbTab & "コピー用紙" & vbTab & "紙製品" & vbTab & "3500" & vbTab & "10")
        sheet.SetClip(21, 0, 1, 7, "1021" & vbTab & "小曾　三三" & vbTab & "関西" & vbTab & "宛名ラベル" & vbTab & "紙製品" & vbTab & "2800" & vbTab & "2")
        sheet.SetClip(22, 0, 1, 7, "1022" & vbTab & "貴俵　健有" & vbTab & "関西" & vbTab & "エアークッション材" & vbTab & "梱包材" & vbTab & "2800" & vbTab & "10")
        sheet.SetClip(23, 0, 1, 7, "1023" & vbTab & "蔭島　太郎" & vbTab & "関西" & vbTab & "段ボール箱（小）" & vbTab & "梱包材" & vbTab & "1900" & vbTab & "10")
        sheet.SetClip(24, 0, 1, 7, "1024" & vbTab & "金賀　憲逸" & vbTab & "関西" & vbTab & "段ボール箱（大）" & vbTab & "梱包材" & vbTab & "2900" & vbTab & "10")
        sheet.SetClip(25, 0, 1, 7, "1025" & vbTab & "楠下　サヤ子" & vbTab & "関東" & vbTab & "コピー用紙" & vbTab & "紙製品" & vbTab & "3500" & vbTab & "8")
        sheet.SetClip(26, 0, 1, 7, "1026" & vbTab & "角本　好七" & vbTab & "関東" & vbTab & "カラーコピー用紙" & vbTab & "紙製品" & vbTab & "4500" & vbTab & "4")
        sheet.SetClip(27, 0, 1, 7, "1027" & vbTab & "蒲沢　宗英" & vbTab & "関東" & vbTab & "コピー用紙" & vbTab & "紙製品" & vbTab & "3500" & vbTab & "10")
        sheet.SetClip(28, 0, 1, 7, "1028" & vbTab & "久角　堅市" & vbTab & "関東" & vbTab & "宛名ラベル" & vbTab & "紙製品" & vbTab & "2800" & vbTab & "10")
        sheet.SetClip(29, 0, 1, 7, "1029" & vbTab & "郷田　圭亮" & vbTab & "関東" & vbTab & "カラーメモシール" & vbTab & "事務用品" & vbTab & "2800" & vbTab & "6")
        sheet.SetClip(30, 0, 1, 7, "1030" & vbTab & "倉員　恵孝" & vbTab & "関東" & vbTab & "エアークッション材" & vbTab & "梱包材" & vbTab & "2800" & vbTab & "4")
        sheet.SetClip(31, 0, 1, 7, "1031" & vbTab & "饒村　九三子" & vbTab & "関東" & vbTab & "段ボール箱（大）" & vbTab & "梱包材" & vbTab & "2900" & vbTab & "11")
        sheet.SetClip(32, 0, 1, 7, "1032" & vbTab & "潮屋　恵勇" & vbTab & "関東" & vbTab & "コピー用紙" & vbTab & "紙製品" & vbTab & "3500" & vbTab & "6")
        sheet.SetClip(33, 0, 1, 7, "1033" & vbTab & "多留　光八" & vbTab & "関東" & vbTab & "宛名ラベル" & vbTab & "紙製品" & vbTab & "2800" & vbTab & "5")
        sheet.SetClip(34, 0, 1, 7, "1034" & vbTab & "茶本　将司" & vbTab & "中部" & vbTab & "コピー用紙" & vbTab & "紙製品" & vbTab & "3500" & vbTab & "6")
        sheet.SetClip(35, 0, 1, 7, "1035" & vbTab & "大部　悟作" & vbTab & "中部" & vbTab & "CD DVDラベル" & vbTab & "紙製品" & vbTab & "5000" & vbTab & "4")
        sheet.SetClip(36, 0, 1, 7, "1036" & vbTab & "立井　健七" & vbTab & "中部" & vbTab & "クリアケース" & vbTab & "事務用品" & vbTab & "2500" & vbTab & "4")
        sheet.SetClip(37, 0, 1, 7, "1037" & vbTab & "高橋　賢一朗" & vbTab & "中部" & vbTab & "軽量バインダー" & vbTab & "事務用品" & vbTab & "3500" & vbTab & "5")
        sheet.SetClip(38, 0, 1, 7, "1038" & vbTab & "請川　公平" & vbTab & "中部" & vbTab & "エアークッション材" & vbTab & "梱包材" & vbTab & "2800" & vbTab & "7")
        sheet.SetClip(39, 0, 1, 7, "1039" & vbTab & "椹木　公己" & vbTab & "関西" & vbTab & "コピー用紙" & vbTab & "紙製品" & vbTab & "3500" & vbTab & "10")
        sheet.SetClip(40, 0, 1, 7, "1040" & vbTab & "田底　清策" & vbTab & "関西" & vbTab & "カラーコピー用紙" & vbTab & "紙製品" & vbTab & "4500" & vbTab & "5")
        sheet.SetClip(41, 0, 1, 7, "1041" & vbTab & "調　佐之助" & vbTab & "関西" & vbTab & "コピー用紙" & vbTab & "紙製品" & vbTab & "3500" & vbTab & "10")
        sheet.SetClip(42, 0, 1, 7, "1042" & vbTab & "垰野　久仁弘" & vbTab & "関西" & vbTab & "宛名ラベル" & vbTab & "紙製品" & vbTab & "2800" & vbTab & "3")
        sheet.SetClip(43, 0, 1, 7, "1043" & vbTab & "麝島　冴" & vbTab & "関西" & vbTab & "エアークッション材" & vbTab & "梱包材" & vbTab & "2800" & vbTab & "10")
        sheet.SetClip(44, 0, 1, 7, "1044" & vbTab & "砂古口　祥公" & vbTab & "関西" & vbTab & "段ボール箱（小）" & vbTab & "梱包材" & vbTab & "1900" & vbTab & "10")
        sheet.SetClip(45, 0, 1, 7, "1045" & vbTab & "桜谷　欣重" & vbTab & "関西" & vbTab & "段ボール箱（大）" & vbTab & "梱包材" & vbTab & "2900" & vbTab & "10")
        sheet.SetClip(46, 0, 1, 7, "1046" & vbTab & "赤野　茂貞" & vbTab & "関東" & vbTab & "コピー用紙" & vbTab & "紙製品" & vbTab & "3500" & vbTab & "10")
        sheet.SetClip(47, 0, 1, 7, "1047" & vbTab & "栄永　貢右" & vbTab & "関東" & vbTab & "カラーコピー用紙" & vbTab & "紙製品" & vbTab & "4500" & vbTab & "5")
        sheet.SetClip(48, 0, 1, 7, "1048" & vbTab & "鷹木　サツ" & vbTab & "関東" & vbTab & "コピー用紙" & vbTab & "紙製品" & vbTab & "3500" & vbTab & "10")
        sheet.SetClip(49, 0, 1, 7, "1049" & vbTab & "澤海　剛義" & vbTab & "関東" & vbTab & "宛名ラベル" & vbTab & "紙製品" & vbTab & "2800" & vbTab & "10")
        sheet.SetClip(50, 0, 1, 7, "1050" & vbTab & "外江　昊司" & vbTab & "関東" & vbTab & "カラーメモシール" & vbTab & "事務用品" & vbTab & "2800" & vbTab & "6")
    End Sub
End Class
