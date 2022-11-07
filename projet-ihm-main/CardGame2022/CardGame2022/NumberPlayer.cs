using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame2022
{
    public partial class NumberPlayer : Form
    {
        #region Association attributes
        private readonly GameController gameController;

        public int NBPlayer
        {
            get
            {
                return (int)NumberOfPlayer.Value;
            }
        }
        #endregion
        public NumberPlayer()
        {
            InitializeComponent();
        }

        private void PlayerNumberValidation_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
