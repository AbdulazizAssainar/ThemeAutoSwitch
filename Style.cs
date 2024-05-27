using System;
using System.Drawing;
using System.Windows.Forms;

namespace GridThemeAutoSwitch
{
    internal class Style
    {
        public static void ApplyLightTheme(DataGridView dataGridView)
        {
            // Disable header visual styles to ensure custom styles are applied
            dataGridView.EnableHeadersVisualStyles = false;

            // Light theme settings
            dataGridView.DefaultCellStyle.BackColor = Color.White;
            dataGridView.DefaultCellStyle.ForeColor = Color.Gray;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 78, 118);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 9f, FontStyle.Bold);

            dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.Black;

            dataGridView.BackgroundColor = Color.WhiteSmoke; // Adjusted for contrast

            dataGridView.GridColor = Color.LightGray;

            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dataGridView.DefaultCellStyle.Padding = new Padding(8);

            // Custom font for the DataGridView
            dataGridView.Font = new Font("Microsoft YaHei UI", 9f, FontStyle.Regular);

            // Capitalize column headers
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.HeaderText = column.HeaderText.ToUpper(); // Capitalize header text
            }

            // Additional professional enhancements
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView.ColumnHeadersHeight = 40;
            dataGridView.RowsDefaultCellStyle.Padding = new Padding(0, 5, 0, 5);
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.RowHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 9f, FontStyle.Bold);
            dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Gray;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.AllowUserToResizeColumns = true;
            dataGridView.AllowUserToResizeRows = true;
        }

        public static void ApplyDarkTheme(DataGridView dataGridView)
        {
            // Disable header visual styles to ensure custom styles are applied
            dataGridView.EnableHeadersVisualStyles = false;

            // Dark theme settings
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dataGridView.DefaultCellStyle.ForeColor = Color.White;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 78, 118);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 9f, FontStyle.Bold);

            dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView.BackgroundColor = Color.DimGray; // Adjusted for contrast

            dataGridView.GridColor = Color.FromArgb(50, 50, 50);

            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dataGridView.DefaultCellStyle.Padding = new Padding(8);

            // Custom font for the DataGridView
            dataGridView.Font = new Font("Microsoft YaHei UI", 9f, FontStyle.Regular);

            // Capitalize column headers
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.HeaderText = column.HeaderText.ToUpper(); // Capitalize header text
            }

            // Additional professional enhancements
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dataGridView.ColumnHeadersHeight = 40;
            dataGridView.RowsDefaultCellStyle.Padding = new Padding(0, 5, 0, 5);
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.RowHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 9f, FontStyle.Bold);
            dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Gray;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.AllowUserToResizeColumns = true;
            dataGridView.AllowUserToResizeRows = true;
        }

        public static void ApplyLightTheme(Form form)
        {
            form.BackColor = Color.White;
            form.ForeColor = Color.Black;
            form.Font = new Font("Microsoft YaHei UI", 10f, FontStyle.Regular);

            foreach (Control control in form.Controls)
            {
                if (control is DataGridView dataGridView)
                {
                    ApplyLightTheme(dataGridView);
                }
                else
                {
                    control.BackColor = Color.White;
                    control.ForeColor = Color.Black;
                    control.Font = new Font("Microsoft YaHei UI", 9f, FontStyle.Regular);
                }
            }
        }

        public static void ApplyDarkTheme(Form form)
        {
            form.BackColor = Color.FromArgb(30, 30, 30);
            form.ForeColor = Color.White;
            form.Font = new Font("Microsoft YaHei UI", 10f, FontStyle.Regular);

            foreach (Control control in form.Controls)
            {
                if (control is DataGridView dataGridView)
                {
                    ApplyDarkTheme(dataGridView);
                }
                else
                {
                    control.BackColor = Color.FromArgb(30, 30, 30);
                    control.ForeColor = Color.White;
                    control.Font = new Font("Microsoft YaHei UI", 9f, FontStyle.Regular);
                }
            }
        }

        public static void UpdateTheme(Form form, bool isLightTheme)
        {
            if (isLightTheme)
            {
                ApplyLightTheme(form);
            }
            else
            {
                ApplyDarkTheme(form);
            }
        }
    }
}
