using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _57Finance.Diger.Cari;

namespace _57Finance
{
    public partial class TahsilatGirisi : Form
    {
        public TahsilatGirisi()
        {
            InitializeComponent();
        }

        private void btnCariSec_Click(object sender, EventArgs e)
        {
            CariSec CariSec = new CariSec();
            CariSec.Show();
        }

        private void TahsilatGirisi_Load(object sender, EventArgs e)
        {
            grpIslem.Enabled = false;
        }

        private void lblCariKod_TextChanged(object sender, EventArgs e)
        {
            if(lblCariKod.Text !="")
            {
                grpIslem.Enabled = true;
            }
        }
    }
}
