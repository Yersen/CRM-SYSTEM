using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmBl_.Models;

namespace CrmUI
{
    public partial class Main : Form
    {
        Context db;
        public Main()
        {
            InitializeComponent();
            db = new Context();
        }

        private void сущностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog(db.Products);
        }
    }
}
