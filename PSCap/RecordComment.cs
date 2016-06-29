using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSCap
{
    public partial class RecordComment : Form
    {
        public RecordComment(string comment)
        {
            InitializeComponent();
            RecordCommentBx.Text = comment;
        }

        public string Comment { get; set; }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Comment = RecordCommentBx.Text;
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Comment = string.Empty;
            DialogResult = DialogResult.Cancel;
        }
    }
}
