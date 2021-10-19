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
    public partial class New_Match : Form
    {
        WeAreTheChamphionsDbContext db;
        public New_Match(WeAreTheChamphionsDbContext db)
        {
            this.db = db;
            InitializeComponent();
        }
    }
}
