using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MiniEstilo.UI.Forms.Lookup
{
    public enum LookupType
    {
        Brand,
        Category,
        AgeGroup,
        Size,
        Color
    }

    public partial class LookupItemForm : Form
    {
        private readonly LookupType _lookupType;

        public LookupItemForm(LookupType lookupType)
        {
            InitializeComponent();

            _lookupType = lookupType;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void LookupItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}