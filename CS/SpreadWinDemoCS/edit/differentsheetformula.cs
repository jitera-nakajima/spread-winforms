﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.edit
{
    public partial class differentsheetformula : SpreadWinDemo.DemoBase
    {
        public differentsheetformula()
        {
            InitializeComponent();

            // SPREADの設定
            InitSpread(fpSpread1);

            // シート1の設定
            InitSheet1(fpSpread1.Sheets[0]);

            // シート2の設定
            InitSheet2(fpSpread1.Sheets[1]);
        }

        private void InitSpread(FarPoint.Win.Spread.FpSpread spread)
        {
            // シートの追加
            FarPoint.Win.Spread.SheetView sht = new FarPoint.Win.Spread.SheetView();
            spread.Sheets.Add(sht);

            // 数式入力を許可
            spread.AllowUserFormulas = true;
        }

        private void InitSheet1(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.datanum1.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 60;
            sheet.Columns[1].Width = 90;
            sheet.Columns[2].Width = 151;
            sheet.Columns[3].Width = 70;
            sheet.Columns[4].Width = 90;
            sheet.Columns[5].Width = 63;
            sheet.Columns[6].Width = 70;

            // シート名の設定
            sheet.SheetName = "製品在庫";
        }

        private void InitSheet2(FarPoint.Win.Spread.SheetView sheet)
        {
            sheet.RowCount = 2;
            sheet.ColumnCount = 4;

            // 数式　製品数
            sheet.Cells[0, 0].Formula = "COUNTIF(製品在庫!B1:B12,\"乳製品\")";
            sheet.Cells[0, 1].Formula = "COUNTIF(製品在庫!B1:B12,\"清涼飲料水\")";
            sheet.Cells[0, 2].Formula = "COUNTIF(製品在庫!B1:B12,\"ビール\")";
            sheet.Cells[0, 3].Formula = "COUNTIF(製品在庫!B1:B12,\"焼酎\")";

            // 数式　在庫計
            sheet.Cells[1, 0].Formula = "SUMIF(製品在庫!B1:B12,\"乳製品\",製品在庫!G1:G12)";
            sheet.Cells[1, 1].Formula = "SUMIF(製品在庫!B1:B12,\"清涼飲料水\",製品在庫!G1:G12)";
            sheet.Cells[1, 2].Formula = "SUMIF(製品在庫!B1:B12,\"ビール\",製品在庫!G1:G12)";
            sheet.Cells[1, 3].Formula = "SUMIF(製品在庫!B1:B12,\"焼酎\",製品在庫!G1:G12)";

            // 列ヘッダ
            sheet.ColumnHeader.Cells[0, 0].Text = "乳製品";
            sheet.ColumnHeader.Cells[0, 1].Text = "清涼飲料水";
            sheet.ColumnHeader.Cells[0, 2].Text = "ビール";
            sheet.ColumnHeader.Cells[0, 3].Text = "焼酎";

            // 行ヘッダ
            sheet.RowHeader.Cells[0, 0].Text = "製品数";
            sheet.RowHeader.Cells[1, 0].Text = "在庫計";

            // 列幅の設定
            sheet.Columns[0].Width = 155;
            sheet.Columns[1].Width = 155;
            sheet.Columns[2].Width = 155;
            sheet.Columns[3].Width = 155;

            sheet.RowHeader.Columns.Default.Width = 52;

            // シート名の設定
            sheet.SheetName = "製品種別集計";
        }  
    }
}