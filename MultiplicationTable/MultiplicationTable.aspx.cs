using System;
using System.Drawing;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultiplicationTable
{
    public partial class _Default : Page
    {
        private int tableSize = 10;
        //int:1
        //decimal :2
        //binary :3
        //hex :4
        private int format = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;
            TableSizeList.SelectedIndex = TableSizeList.Items.IndexOf(TableSizeList.Items.FindByValue(tableSize.ToString()));

            BuildTable();
        }

        private void BuildTable()
        {
            MultiplicationTbl.Rows.Clear();
            tableSize = int.Parse(TableSizeList.SelectedItem.Value);
            for (int i = 0; i <= tableSize; i++)
            {
                var row = new TableRow();
                if (i == 0)
                {
                    //First Row
                    row.Cells.Add(BuildCell("X"));
                    for (int j = 1; j <= tableSize; j++)
                    {
                        BuildBorderCells(row, j.ToString());
                    }
                }
                else
                {
                    for (int j = 0; j <= tableSize; j++)
                    {
                        if (j == 0)
                        {
                            //First Column
                            BuildBorderCells(row, i.ToString());
                        }
                        else
                        {
                            var cellValue = BuildFormat((i * j));
                            var cell = BuildCell(cellValue);
                            cell.ToolTip = $"{i}X{j}={cellValue}";
                            if (i == j)
                            {
                                cell.BackColor = Color.LightBlue;
                            }
                            row.Cells.Add(cell);
                        }
                    }
                }
                MultiplicationTbl.Rows.Add(row);
            }
        }

        private string BuildFormat(int v)
        {
            format = int.Parse(FormatList.SelectedItem.Value);
            switch (format)
            {
                //int
                case 1:
                    return v.ToString();
                //decimal
                case 2:
                    return v.ToString("#.00");
                //binary
                case 3:
                    return Convert.ToString(v, 2);
                //hex
                case 4:
                    return v.ToString("X");
                default: return v.ToString();
            }
        }

        protected void Size_Selection_Change(Object sender, EventArgs e)
        {
            BuildTable();
        }

        protected void Format_Selection_Change(Object sender, EventArgs e)
        {
            BuildTable();
        }
        private void BuildBorderCells(TableRow row, string text)
        {
            var cell = BuildCell(text);
            cell.BackColor = Color.Beige;
            row.Cells.Add(cell);
        }
        private TableCell BuildCell(string text)
        {
            var newCell = new TableCell
            {
                Text = text,
            };
            newCell.ApplyStyle(GetCommonStyle());
            return newCell;
        }
        private TableItemStyle GetCommonStyle()
        {
            return new TableItemStyle
            {
                HorizontalAlign = HorizontalAlign.Center,
                VerticalAlign = VerticalAlign.Middle,
                Width = Unit.Pixel(100),
                BorderColor = Color.Black,
                BorderStyle = BorderStyle.Solid,
                BorderWidth = 1
            };
        }
    }
}