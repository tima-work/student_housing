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
    public partial class NewRule : Form
    {
        private Form go_back_form;
        private Rule rule_to_update;
        private Control[] all_controls;
        private ResizeClass[] all_resizes = new ResizeClass[6];
        public NewRule(Form go_back_form)
        {
            InitializeComponent();
            this.go_back_form = go_back_form;
            all_controls = new Control[6] { panel2, lblAddNewRuleTitle, btnBack4, lblEnterRule, tbRuleText, btnAddRule };
            for (int i = 0; i < all_resizes.Length; i++)
                all_resizes[i] = new ResizeClass(all_controls[i], all_controls[i].Parent);
            this.Resize += ResizeThisWindow;
        }


        private void btnAddRule_Click(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Text == "Add rule")
                {
                    MainPageForm.ruleManager.AddNewRule(tbRuleText.Text);
                    tbRuleText.Text = string.Empty;
                    MessageBox.Show("Added successfully");
                }
                else
                {
                    if (rule_to_update.RuleName != tbRuleText.Text)
                        MainPageForm.ruleManager.UpdateRule(rule_to_update, tbRuleText.Text);
                    MessageBox.Show("Updated successfully");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void OpenNewRule()
        {
            tbRuleText.Text = string.Empty;
            btnAddRule.Text = "Add rule";
            lblAddNewRuleTitle.Text = "Add new rule";
            OpenThisForm();

        }

        public void OpenExistingRule(Rule rule)
        {
            rule_to_update = rule;
            tbRuleText.Text = rule.RuleName;
            btnAddRule.Text = "Update rule";
            lblAddNewRuleTitle.Text = "Update rule";
            OpenThisForm();

        }

        public void OpenThisForm()
        {
            MainPageForm.GoToOtherForm(go_back_form, this);
        }


        private void ResizeThisWindow(object sender, EventArgs e)
        {
            MainPageForm.ResizeSmth(all_resizes);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            (this.go_back_form as RuleForm).RefreshRules();
            (this.go_back_form as RuleForm).ResizeThisWindow(sender, e);
            MainPageForm.GoToOtherForm(this, go_back_form);
        }


    }
}
