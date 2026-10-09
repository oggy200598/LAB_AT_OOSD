using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich.Forms
{
    public static class UiStyle
    {
        private static readonly Color Navy = Color.FromArgb(25, 39, 58);
        private static readonly Color NavyLight = Color.FromArgb(38, 55, 77);
        private static readonly Color Champagne = Color.FromArgb(197, 164, 103);
        private static readonly Color ChampagneLight = Color.FromArgb(244, 235, 216);
        private static readonly Color Background = Color.FromArgb(250, 249, 246);
        private static readonly Color White = Color.White;
        private static readonly Color Border = Color.FromArgb(225, 220, 210);
        private static readonly Color TextColor = Color.FromArgb(48, 53, 60);
        private static readonly Color MutedText = Color.FromArgb(115, 119, 124);

        public static void Apply(Form form)
        {
            form.BackColor = Background;
            form.ForeColor = TextColor;
            form.Font = new Font("Segoe UI", 9F, FontStyle.Regular);

            StyleControls(form.Controls);
        }

        private static void StyleControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is DataGridView grid)
                {
                    grid.BackgroundColor = White;
                    grid.BorderStyle = BorderStyle.None;
                    grid.GridColor = Border;
                    grid.EnableHeadersVisualStyles = false;
                    grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                    grid.ColumnHeadersHeight = 42;
                    grid.RowTemplate.Height = 36;
                    grid.ColumnHeadersDefaultCellStyle.BackColor = Navy;
                    grid.ColumnHeadersDefaultCellStyle.ForeColor = ChampagneLight;
                    grid.ColumnHeadersDefaultCellStyle.Font =
                        new Font("Segoe UI", 9F, FontStyle.Bold);
                    grid.ColumnHeadersDefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleLeft;
                    grid.ColumnHeadersDefaultCellStyle.Padding =
                        new Padding(8, 0, 8, 0);

                    grid.DefaultCellStyle.BackColor = White;
                    grid.DefaultCellStyle.ForeColor = TextColor;
                    grid.DefaultCellStyle.Font =
                        new Font("Segoe UI", 9F, FontStyle.Regular);
                    grid.DefaultCellStyle.SelectionBackColor = ChampagneLight;
                    grid.DefaultCellStyle.SelectionForeColor = Navy;
                    grid.DefaultCellStyle.Padding = new Padding(6, 2, 6, 2);

                    grid.AlternatingRowsDefaultCellStyle.BackColor =
                        Color.FromArgb(248, 247, 243);
                    grid.AlternatingRowsDefaultCellStyle.ForeColor = TextColor;
                    grid.CellBorderStyle =
                        DataGridViewCellBorderStyle.SingleHorizontal;
                    grid.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;
                    grid.MultiSelect = false;
                    grid.RowHeadersVisible = false;
                }
                else if (control is Button button)
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 1;
                    button.FlatAppearance.BorderColor = Champagne;
                    button.FlatAppearance.MouseOverBackColor = NavyLight;
                    button.FlatAppearance.MouseDownBackColor = Champagne;

                    button.BackColor = Navy;
                    button.ForeColor = ChampagneLight;
                    button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    button.Cursor = Cursors.Hand;
                    button.Height = Math.Max(button.Height, 35);
                    button.Padding = new Padding(10, 4, 10, 4);
                }
                else if (control is TextBox textBox)
                {
                    textBox.Font = new Font("Segoe UI", 9F);
                    textBox.BackColor = White;
                    textBox.ForeColor = TextColor;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.Font = new Font("Segoe UI", 9F);
                    comboBox.BackColor = White;
                    comboBox.ForeColor = TextColor;
                    comboBox.FlatStyle = FlatStyle.Flat;
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Font = new Font("Segoe UI", 9F);
                    dateTimePicker.CalendarMonthBackground = White;
                    dateTimePicker.CalendarTitleBackColor = Navy;
                    dateTimePicker.CalendarTitleForeColor = ChampagneLight;
                    dateTimePicker.CalendarTrailingForeColor = MutedText;
                }
                else if (control is Label label)
                {
                    label.ForeColor = Navy;
                    label.Font = new Font("Segoe UI", 9F);
                }
                else if (control is FlowLayoutPanel || control is TableLayoutPanel)
                {
                    control.BackColor = Background;
                }
                else if (control is Panel)
                {
                    control.BackColor = Background;
                }

                StyleControls(control.Controls);
            }
        }
    }
}