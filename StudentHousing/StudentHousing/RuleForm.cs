using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousing
{
    public partial class RuleForm : Form
    {
        private Form go_back_form;
        private NewRule newRule;
        private Control[] all_controls;
        private List<ResizeClass> all_resizes = new List<ResizeClass>();

        public RuleForm(Form go_back_form)
        {
            InitializeComponent();
            this.go_back_form = go_back_form;
            newRule = new NewRule(this);
            all_controls = new Control[5] { panel1, lblRules, btnBack, flpRules, btnAddRule };
            for (int i = 0; i < all_controls.Length; i++)
                all_resizes.Add(new ResizeClass(all_controls[i], all_controls[i].Parent));
            this.Resize += ResizeThisWindow;
            btnAddRule.Visible = (go_back_form as MainPageForm).UserIsAdmin();
            RefreshRules();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainPageForm.GoToOtherForm(this, go_back_form);
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            newRule.OpenNewRule();
        }


        private void btnNewRule_Click(object sender, EventArgs e)
        {
            newRule.OpenNewRule();
        }

        private void lblUpdateRule_Click(Object sender, EventArgs e)
        {
            if ((this.go_back_form as MainPageForm).UserIsAdmin())
                newRule.OpenExistingRule(MainPageForm.ruleManager.GetRules()[Convert.ToInt32((sender as Label).Text.Split(". ")[0]) - 1]);
        }

        public void RefreshRules()
        {
            Rule[] var = MainPageForm.ruleManager.GetRules();
            flpRules.Controls.Clear();
            for (int i = 0; i < var.Length; i++)
            {
                Label current_label = new Label();
                current_label.Text = $"{i + 1}. {var[i].RuleName}";
                current_label.AutoSize = true;
                current_label.Font = new Font("Segoe UI", 25);
                current_label.Width = flpRules.Width;
                current_label.DoubleClick += lblUpdateRule_Click;
                flpRules.Controls.Add(current_label);
                all_resizes.Add(new ResizeClass(current_label, flpRules));
            }
        }

        public void ResizeThisWindow(object sender, EventArgs e)
        {
            MainPageForm.ResizeSmth(all_resizes.ToArray());
        }


    }
}
