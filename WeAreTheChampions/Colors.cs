using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampionsData.Models;

namespace WeAreTheChampions
{
    public partial class Colors : Form
    {
        WeAreTheChamphionsDbContext db;

        public Colors(WeAreTheChamphionsDbContext db)
        {
            this.db = db;
            InitializeComponent();
            ColorsList();
            FormReset();
        }

        private void FormReset()
        {
            txtColorName.Clear();
            gbBackGroundColor.BackColor = System.Drawing.Color.White;
            lblRed.Text = "000";
            lblGreen.Text = "000";
            lblBlue.Text = "000";
            hsbRed.Value = hsbRed.Minimum;
            hsbBlue.Value = hsbBlue.Minimum;
            hsbGreen.Value = hsbGreen.Minimum;
        }

        private void ColorsList()
        {
            dgvColors.DataSource = db.Colors.ToList();
        }

        private void hsbRed_Scroll(object sender, ScrollEventArgs e)
        {
            lblRed.Text = hsbRed.Value.ToString();
            gbBackGroundColor.BackColor = System.Drawing.Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
        }

        private void hsbGreen_Scroll(object sender, ScrollEventArgs e)
        {
            lblGreen.Text = hsbGreen.Value.ToString();
            gbBackGroundColor.BackColor = System.Drawing.Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
        }

        private void hsbBlue_Scroll(object sender, ScrollEventArgs e)
        {
            lblBlue.Text = hsbBlue.Value.ToString();
            gbBackGroundColor.BackColor = System.Drawing.Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string colorName = txtColorName.Text.Trim();

            if (colorName == "")
            {
                MessageBox.Show("Renk Adını Giriniz");
                return;
            }

            db.Colors.Add(new WeAreTheChampionsData.Color()
            {
                ColorName = txtColorName.Text,
                Red = (byte)hsbRed.Value,
                Blue = (byte)hsbBlue.Value,
                Green = (byte)hsbGreen.Value,
            });
            db.SaveChanges();
            ColorsList();
            FormReset();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvColors.SelectedRows.Count != 1)
                return;

            int selectLine = ((WeAreTheChampionsData.Color)dgvColors.SelectedRows[0].DataBoundItem).Id;
            var delete = db.Colors.Where(x => x.Id == selectLine).FirstOrDefault();
            db.Colors.Remove(delete);
            db.SaveChanges();
            ColorsList();
            FormReset();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvColors.SelectedRows.Count != 1)
            {
                return;
            }
            var selected = ((WeAreTheChampionsData.Color)dgvColors.SelectedRows[0].DataBoundItem).Id;

            var update = db.Colors.Find(selected);
           
            update.Red = (byte)hsbRed.Value;
            update.Blue = (byte)hsbBlue.Value;
            update.Green = (byte)hsbGreen.Value;

            foreach (var item in db.Colors)
            {
                if (selected == item.Id)
                {
                    lblColorsBackGround.BackColor = System.Drawing.Color.FromArgb(item.Red,  item.Green, item.Blue);
                   
                }
            }
            db.SaveChanges();
            ColorsList();
        }

        private void dgvColors_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvColors.SelectedRows.Count != 1)
            {
                return;
            }
            int selected = (int)dgvColors.SelectedRows[0].Cells[0].Value;

            foreach (var item in db.Colors)
            {
                if (selected == item.Id)
                {
                    hsbRed.Value = item.Red;
                    lblRed.Text = item.Red.ToString();
                    hsbBlue.Value = item.Blue;
                    lblBlue.Text = item.Blue.ToString();
                    hsbGreen.Value = item.Green;
                    lblGreen.Text = item.Green.ToString();
                    gbBackGroundColor.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                    lblColorsBackGround.BackColor = System.Drawing.Color.FromArgb(item.Red,  item.Green, item.Blue);
                }
            }
            gbBackGroundColor.BackColor = System.Drawing.Color.White;
        }
    }
}
