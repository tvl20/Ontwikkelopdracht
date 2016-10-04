using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OntwikkelopdrachtSE
{
    public partial class CharacterCreationDetails : Form
    {
        public enum Class { Knight, Slugger, Crusader, Paladin};
        public Class _class;
        public CharacterCreationDetails()
        {
            InitializeComponent();
            cb_Class.Items.Add("Knight");
            cb_Class.Items.Add("Slugger");
            cb_Class.Items.Add("Crusader");
            cb_Class.Items.Add("Paladin");
            cb_Class.SelectedIndex = 0;
            _class = Class.Knight;
        }

        private void cb_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Class.SelectedItem.ToString() == "Knight")
            {
                lb_ATK.Text = "Medium";
                lb_DEF.Text = "Medium";
                lb_MaxAP.Text = "Medium";
                lb_APperATK.Text = "Medium";
                lb_RegAP.Text = "Medium";
                lb_MaxHP.Text = "Medium";
                lb_MPperMove.Text = "Medium";
                _class = Class.Knight;
            }
            else if (cb_Class.SelectedItem.ToString() == "Slugger")
            {
                lb_ATK.Text = "High";
                lb_DEF.Text = "Medium";
                lb_MaxAP.Text = "Low";
                lb_APperATK.Text = "High";
                lb_RegAP.Text = "Medium";
                lb_MaxHP.Text = "Medium";
                lb_MPperMove.Text = "Medium";
                _class = Class.Slugger;
            }
            else if (cb_Class.SelectedItem.ToString() == "Crusader")
            {
                lb_ATK.Text = "Low";
                lb_DEF.Text = "High";
                lb_MaxAP.Text = "High";
                lb_APperATK.Text = "Medium";
                lb_RegAP.Text = "Low";
                lb_MaxHP.Text = "High";
                lb_MPperMove.Text = "High";
                _class = Class.Crusader;
            }
            else if (cb_Class.SelectedItem.ToString() == "Paladin")
            {
                lb_ATK.Text = "Medium";
                lb_DEF.Text = "Low";
                lb_MaxAP.Text = "High";
                lb_APperATK.Text = "Low";
                lb_RegAP.Text = "Medium";
                lb_MaxHP.Text = "Low";
                lb_MPperMove.Text = "Low";
                _class = Class.Paladin;
            }
        }

        private void bt_Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
