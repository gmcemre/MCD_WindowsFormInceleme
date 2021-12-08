using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_WindowsFormInceleme
{
    public partial class MerhabaForm : Form
    {
        
        public MerhabaForm(string metin)
        {
            InitializeComponent();
            //Eğer bir windows form elamanına dokunmanız gerekli ise burdan veya daha aşağıda bu işlemleri yapabilirsiniz.
            label1.Text  =metin  ;
        }

        public string TxtMesajDegeri { get; set; }

        private void MerhabaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
